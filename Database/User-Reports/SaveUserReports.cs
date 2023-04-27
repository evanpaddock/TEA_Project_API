using MySql.Data.MySqlClient;
using TEA_Project_API.Models;

namespace TEA_Project_API.Database.User_Reports
{
    public class SaveUserReports
    {
        static public void NewUserReport(UserReport myUserReport){
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            //Creates UserReport
            string stm = @" INSERT INTO user_reports_saved(Report_ID,User_ID)
                            VALUES(@Report_ID, @User_ID);";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@Report_ID", myUserReport.Report_ID);
            cmd.Parameters.AddWithValue("@User_ID", myUserReport.User_ID);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
    }
}