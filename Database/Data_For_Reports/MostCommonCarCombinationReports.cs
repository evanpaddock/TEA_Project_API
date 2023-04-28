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

            string stm = @"SELECT Fuel_Type, COUNT(Fuel_Type) as TotalCount
                            FROM car
                            GROUP BY Fuel_Type;";
            using var cmd = new MySqlCommand(stm, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();

            List<CarCombinations> myCarCombinations = new List<CarCombinations>();

            while (rdr.Read()) {
                CarCombinations myCarCombination = new CarCombinations(){
                    FuelType=rdr.GetString(0), TotalSame=rdr.GetInt32(1)
                };
                
                myCarCombinations.Add(myCarCombination);
            }

            return myCarCombinations;
        }
    }
}