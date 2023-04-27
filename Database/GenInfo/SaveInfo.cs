using MySql.Data.MySqlClient;

namespace TEA_Project_API.Database.GenInfo
{
    public class SaveInfo
    {
        static public Models.GenInfo SaveGenInfo(string title, string text){
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE gen_info_page
                            SET Title=@Title, Text=@Text
                            WHERE ID = 0;";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Text", text);

            cmd.Prepare();

            using MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();

            Models.GenInfo myInfoPageText = new Models.GenInfo(){};
                
            return myInfoPageText;
        }
    }
}