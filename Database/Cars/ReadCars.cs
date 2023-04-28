using MySql.Data.MySqlClient;
using TEA_Project_API.Models;

namespace TEA_Project_API.Database.Cars
{
    public class ReadCars
    {
        static public List<Car>  GetAllCars(){
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT * FROM CAR";
            using var cmd = new MySqlCommand(stm, con);
            using MySqlDataReader rdr = cmd.ExecuteReader();

            List<Car> myCars = new List<Car>();

            while (rdr.Read()) {
                Car myCar = new Car(){CarID=rdr.GetInt32(0), Make=rdr.GetString(1), 
                                        Model=rdr.GetString(2), Year=rdr.GetString(3), Trim=rdr.GetString(4), 
                                        Gas_Mileage=rdr.GetString(5), Tank_Size=rdr.GetString(6), Fuel_Type=rdr.GetString(7),
                                        HorsePower = rdr.GetInt32(8), Torque = rdr.GetInt32(9), Transmission = rdr.GetString(10),
                                        TimesViewed=rdr.GetInt32(11), Deleted = rdr.GetBoolean(12)};
                
                myCars.Add(myCar);
            }

            con.Close();

            return myCars;
        }
        static public Car GetCar(int id){
            
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT * FROM CAR WHERE CarID=@id";

            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();

            using MySqlDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            Car myCar = new Car(){CarID=rdr.GetInt32(0), Make=rdr.GetString(1), 
                                        Model=rdr.GetString(2), Year=rdr.GetString(3), Trim=rdr.GetString(4), 
                                        Gas_Mileage=rdr.GetString(5), Tank_Size=rdr.GetString(6), Fuel_Type=rdr.GetString(7),
                                        HorsePower = rdr.GetInt32(8), Torque = rdr.GetInt32(9), Transmission = rdr.GetString(10),
                                        TimesViewed=rdr.GetInt32(11), Deleted = rdr.GetBoolean(12)};

            return myCar;
        }
    }   
}