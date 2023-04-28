using MySql.Data.MySqlClient;
using TEA_Project_API.Models;

namespace TEA_Project_API.Database.Data_For_Reports
{
    public class UserStateCounts
    {
        static public List<UserStateTotals> GetUserStateTotals(){
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT State, COUNT(DISTINCT User_ID) as TotalCount
                            FROM user
                            GROUP BY State;";
            using var cmd = new MySqlCommand(stm, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();

            List<UserStateTotals> myStateCounts = new List<UserStateTotals>();

            while (rdr.Read()) {
                UserStateTotals myStateCount = new UserStateTotals(){
                    State=rdr.GetString(0), TotalCount=rdr.GetInt32(1)
                };
                
                myStateCounts.Add(myStateCount);
            }
            
            con.Close();

            return myStateCounts;
        }
    }
}