using MySql.Data.MySqlClient;
using TEA_Project_API.Models;

namespace TEA_Project_API.Database.Roles
{
    public class ReadRoles
    {
        static public List<Role>  GetAllRoles(){
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT * FROM ROLE";
            using var cmd = new MySqlCommand(stm, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();

            List<Role> myRoles = new List<Role>();

            while (rdr.Read()) {
                Role myRole = new Role(){Role_ID=rdr.GetInt32(0),RoleName=rdr.GetString(1)};
                
                myRoles.Add(myRole);
            }
            return myRoles;
        }
        static public Role GetRole(int id){
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT * FROM ROLE WHERE Role_ID=@id";

            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();

            using MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();

            Role myRole = new Role(){Role_ID=rdr.GetInt32(0),RoleName=rdr.GetString(1)};
                
            return myRole;
        }
    }
}