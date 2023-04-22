using MySql.Data.MySqlClient;
using TEA_Project_API.Models;

namespace TEA_Project_API.Database.Users
{
    public class ReadUsers
    {
        static public List<User>  GetAllUsers(){
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT * FROM USER";
            using var cmd = new MySqlCommand(stm, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();

            List<User> myUsers = new List<User>();

            while (rdr.Read()) {
                User myUser = new User(){User_ID=rdr.GetInt32(2),UserName=rdr.GetString(0), 
                                        Password=rdr.GetString(1), UserEmail=rdr.GetString(3), DateJoined=rdr.GetString(4),
                                        FirstName=rdr.GetString(5),LastName=rdr.GetString(6), State=rdr.GetString(7), Role_ID=rdr.GetInt32(8)
                                        };
                
                myUsers.Add(myUser);
            }
            return myUsers;
        }
        static public User GetUser(int id){
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT * FROM USER WHERE User_ID=@id";

            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();

            using MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            User myUser = new User(){User_ID=rdr.GetInt32(2),UserName=rdr.GetString(0), 
                                        Password=rdr.GetString(1), UserEmail=rdr.GetString(3), DateJoined=rdr.GetString(4),
                                        FirstName=rdr.GetString(5),LastName=rdr.GetString(6), State=rdr.GetString(7), Role_ID=rdr.GetInt32(8)
                                        };
                
            return myUser;
        }
    }
}