using MySql.Data.MySqlClient;
using TEA_Project_API.Models;

namespace TEA_Project_API.Database.Report_Cars
{
    public class SaveReportCars
    {
        static public void NewCarReport(CarReport myCarReport){
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            //Creates CarReport
            string stm = @" INSERT INTO cars_for_reports(Report_ID,CarID)
                            VALUES(@Report_ID, @CarID);";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@Report_ID", myCarReport.Report_ID);
            cmd.Parameters.AddWithValue("@CarID", myCarReport.CarID);

            cmd.Prepare();

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}