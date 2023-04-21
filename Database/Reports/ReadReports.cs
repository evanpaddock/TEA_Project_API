using MySql.Data.MySqlClient;
using TEA_Project_API.Models;

namespace TEA_Project_API.Database.Reports
{
    public class ReadReports
    {
        static public List<Report>  GetAllReports(){
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT * FROM REPORT";
            using var cmd = new MySqlCommand(stm, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();

            List<Report> myReports = new List<Report>();

            while (rdr.Read()) {
                Report myReport = new Report(){Report_ID=rdr.GetInt32(0),ReportName=rdr.GetString(1), 
                                        Deleted=rdr.GetBoolean(2)
                                        };
                
                myReports.Add(myReport);
            }
            return myReports;
        }
        static public Report GetReport(int id){
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT * FROM REPORT WHERE Report_ID=@id";

            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();

            using MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            Report myReport = new Report(){Report_ID=rdr.GetInt32(0),ReportName=rdr.GetString(1), 
                                        Deleted=rdr.GetBoolean(2)
                                        };
                
            return myReport;
        }
    }
}