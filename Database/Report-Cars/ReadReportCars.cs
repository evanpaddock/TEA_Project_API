using MySql.Data.MySqlClient;
using TEA_Project_API.Models;

namespace TEA_Project_API.Database.Report_Cars
{
    public class ReadReportCars
    {
        static public List<CarReport>  GetAllCarReports(){
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @" SELECT * 
                            FROM cars_for_reports;";

            using var cmd = new MySqlCommand(stm, con);
            
            using MySqlDataReader rdr = cmd.ExecuteReader();

            List<CarReport> myCarReports = new List<CarReport>();

            while (rdr.Read()) {
                CarReport myCarReport = new CarReport(){Report_ID=rdr.GetInt32(0), CarID=rdr.GetInt32(1)};
                
                myCarReports.Add(myCarReport);
            }

            con.Close();

            return myCarReports;
        }
        static public CarReport GetCarReport(int Report_ID){
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @" SELECT * 
                            FROM cars_for_reports
                            WHERE Report_ID = @Report_ID;";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@Report_ID", Report_ID);
            cmd.Prepare();


            using MySqlDataReader rdr = cmd.ExecuteReader();

            CarReport myCarReport = new CarReport(){Report_ID=rdr.GetInt32(0), CarID=rdr.GetInt32(1)};
            
            return myCarReport;
        }
    }
}