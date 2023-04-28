using MySql.Data.MySqlClient;
using TEA_Project_API.Models;

namespace TEA_Project_API.Database.GenInfo
{
    public class ReadInfo
    {
        static public Models.GenInfo GetInfoPageData(){
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT Title, Text
                            FROM gen_info_page
                            WHERE ID = 0;";

            using var cmd = new MySqlCommand(stm, con);
            cmd.Prepare();

            using MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();

            Models.GenInfo myInfoPageText = new Models.GenInfo(){Title=rdr.GetString(0), Text=rdr.GetString(1)};
                
            con.Close();

            return myInfoPageText;
        }
    }
}