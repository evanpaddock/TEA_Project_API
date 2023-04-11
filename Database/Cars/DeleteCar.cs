using MySql.Data.MySqlClient;

namespace TEA_Project_API.Database.Cars
{
    public class DeleteCar
    {
        static public void DeleteACar(int id){
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE  
                            WHERE CarID=@id";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
    }
}