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

            string stm = @"SELECT * FROM User";
            using var cmd = new MySqlCommand(stm, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();

            List<User> myUsers = new List<User>();

            while (rdr.Read()) {
                User myUser = new User(){UserID=rdr.GetInt32(0), Make=rdr.GetString(1), 
                                        Model=rdr.GetString(2), Year=rdr.GetString(3), Trim=rdr.GetString(4), 
                                        Gas_Mileage=rdr.GetString(5), Tank_Size=rdr.GetString(6), Fuel_Type=rdr.GetString(7),
                                        HorsePower = rdr.GetInt32(8), Torque = rdr.GetInt32(9), Transmission = rdr.GetString(10),
                                        Deleted = rdr.GetBoolean(11)};
                
                myUsers.Add(myUser);
            }
            return myUsers;
        }
        static public User GetUser(int id){
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT * FROM User WHERE UserID=@id";

            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();

            using MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            User myUser = new User(){UserID=rdr.GetInt32(0), Make=rdr.GetString(1), 
                                    Model=rdr.GetString(2), Year=rdr.GetString(3), Trim=rdr.GetString(4), 
                                    Gas_Mileage=rdr.GetString(5), Tank_Size=rdr.GetString(6), Fuel_Type=rdr.GetString(7),
                                    HorsePower = rdr.GetInt32(8), Torque = rdr.GetInt32(9), Transmission = rdr.GetString(10),
                                    Deleted = rdr.GetBoolean(11)};
                
            return myUser;
        }
    }
}