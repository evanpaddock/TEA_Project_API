using MySql.Data.MySqlClient;
using TEA_Project_API.Models;

namespace TEA_Project_API.Database.Data_For_Reports
{
    public class MostCommonCarCombinationReports
    {
        static public List<CarCombinations> GetTotalCombinations(){
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT c.CarID, cr.CarID, COUNT(DISTINCT c.Report_ID) as TimesCounted
                            FROM cars_for_reports c JOIN cars_for_reports cr on (c.Report_ID = cr.Report_ID)
                            WHERE c.CarID != cr.CarID
                            ORDER BY TimesCounted DESC
                            LIMIT 10;";
            using var cmd = new MySqlCommand(stm, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();

            List<CarCombinations> myCarCombinations = new List<CarCombinations>();

            while (rdr.Read()) {
                CarCombinations myCarCombination = new CarCombinations(){
                    FirstCarMake=rdr.GetString(0), SecondCarMake=rdr.GetString(1), TotalSame=rdr.GetInt32(2)
                };
                
                myCarCombinations.Add(myCarCombination);
            }


            return myCarCombinations;
        }
    }
}