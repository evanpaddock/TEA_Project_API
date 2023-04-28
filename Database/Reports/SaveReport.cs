using MySql.Data.MySqlClient;
using TEA_Project_API.Models;

namespace TEA_Project_API.Database.Reports
{
    public class SaveReport
    {
        static public void NewReport(Report myReport){
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO REPORT(Report_ID, ReportName, Deleted)
                            VALUES(@Report_ID, @ReportName, @Deleted)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@Report_ID", myReport.Report_ID);
            cmd.Parameters.AddWithValue("@ReportName", myReport.ReportName);
            cmd.Parameters.AddWithValue("@Deleted", myReport.Deleted);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
        static public void UpdateReport(Report myReport){
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @$"UPDATE REPORT 
                            SET ReportName=@ReportName, Deleted=@Deleted
                            WHERE Report_ID=@Report_ID";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@ReportName", myReport.ReportName);
            cmd.Parameters.AddWithValue("@Deleted", myReport.Deleted);
            cmd.Parameters.AddWithValue("@Report_ID", myReport.Report_ID);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
    }
}