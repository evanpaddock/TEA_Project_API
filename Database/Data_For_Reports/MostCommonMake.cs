using MySql.Data.MySqlClient;
using TEA_Project_API.Models;

namespace TEA_Project_API.Database.Data_For_Reports
{
    public class MostCommonMake
    {
        static public List<MakeAndTotal> GetMakeAndTotals(){
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT Make, TimesViewed
                            FROM car
                            ORDER BY TimesViewed DESC
                            LIMIT 10;";
            using var cmd = new MySqlCommand(stm, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();

            List<MakeAndTotal> myMostCommonMakes = new List<MakeAndTotal>();

            while (rdr.Read()) {
                MakeAndTotal myMostCommonMake = new MakeAndTotal(){
                    Make=rdr.GetString(0), Count=rdr.GetInt32(1)
                };
                
                myMostCommonMakes.Add(myMostCommonMake);
            }
            
            return myMostCommonMakes;
        }
    }
}