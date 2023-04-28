using MySql.Data.MySqlClient;
using TEA_Project_API.Models;

namespace TEA_Project_API.Database.User_Reports
{
    public class ReadUserReports
    {
        static public List<UserReport>  GetAllUserReports(){
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @" SELECT * 
                            FROM user_reports_saved;";
            using var cmd = new MySqlCommand(stm, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();

            List<UserReport> myUserReports = new List<UserReport>();

            while (rdr.Read()) {
                UserReport myUserReport = new UserReport(){Report_ID=rdr.GetInt32(0), User_ID=rdr.GetInt32(1)};
                
                myUserReports.Add(myUserReport);
            }

            return myUserReports;
        }
        static public UserReport GetUserReport(int User_ID){
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @" SELECT * 
                            FROM user_reports_saved
                            WHERE User_ID = @User_ID;";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@id", User_ID);
            cmd.Prepare();


            using MySqlDataReader rdr = cmd.ExecuteReader();

            UserReport myUserReport = new UserReport(){Report_ID=rdr.GetInt32(0), User_ID=rdr.GetInt32(1)};
            
            return myUserReport;
        }
    }
}