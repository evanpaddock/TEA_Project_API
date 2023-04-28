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

            string stm = @" SELECT * 
                            FROM ROLE";
            using var cmd = new MySqlCommand(stm, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();

            List<Role> myRoles = new List<Role>();

            while (rdr.Read()) {
                Role myRole = new Role(){Role_ID=rdr.GetInt32(0), RoleName=rdr.GetString(1), Edit_Page_TF=rdr.GetBoolean(2),
                Reports_Able_TF=rdr.GetBoolean(3), Admin_Page_TF=rdr.GetBoolean(4), User_Page_TF=rdr.GetBoolean(5)};
                
                myRoles.Add(myRole);
            }

            con.Close();

            return myRoles;
        }
        static public Role GetRole(int role_id){
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT * FROM ROLE r
                            WHERE Role_ID=@id";

            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@id", role_id);
            cmd.Prepare();

            using MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();

            Role myRole = new Role(){Role_ID=rdr.GetInt32(0), RoleName=rdr.GetString(1), Edit_Page_TF=rdr.GetBoolean(2),
                Reports_Able_TF=rdr.GetBoolean(3), Admin_Page_TF=rdr.GetBoolean(4), User_Page_TF=rdr.GetBoolean(5)};
            
            con.Close();
            return myRole;
        }
    }
}