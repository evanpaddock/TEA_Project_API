using MySql.Data.MySqlClient;
using TEA_Project_API.Models;

namespace TEA_Project_API.Database.Data_For_Reports
{
    public class UserRegistrationBiWeekly
    {
        static public List<UserDatesJoined> GetUserDatesJoined(){
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT DateJoined, COUNT(DateJoined) as Total
                            FROM user
                            GROUP BY DateJoined;";
            using var cmd = new MySqlCommand(stm, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();

            List<UserDatesJoined> myMostCommonMakes = new List<UserDatesJoined>();

            while (rdr.Read()) {
                UserDatesJoined myMostCommonMake = new UserDatesJoined(){
                    DateJoined=rdr.GetString(0), Total=rdr.GetInt32(1)
                };
                
                myMostCommonMakes.Add(myMostCommonMake);
            }


            return myMostCommonMakes;
        }
    }
}