using MySql.Data.MySqlClient;
using TEA_Project_API.Models;

namespace TEA_Project_API.Database.Cars
{
    public class SaveCars
    {
        static public void NewCar(Car myCar){
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO CAR(Make, Model, Trim, Year, Deleted, Gas_Mileage, Tank_Size, Fuel_Type, HorsePower, Torque, Transmission, TimesViewed) 
                            VALUES(@Make, @Model, @Trim, @Year, @Deleted, @Gas_Mileage, @Tank_Size, @Fuel_Type, @HorsePower, @Torque, @Transmission, @TimesViewed)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@Make", myCar.Make);
            cmd.Parameters.AddWithValue("@Model", myCar.Model);
            cmd.Parameters.AddWithValue("@Trim", myCar.Trim);
            cmd.Parameters.AddWithValue("@Year", myCar.Year);
            cmd.Parameters.AddWithValue("@Deleted", myCar.Deleted);
            cmd.Parameters.AddWithValue("@Gas_Mileage", myCar.Gas_Mileage);
            cmd.Parameters.AddWithValue("@Tank_Size", myCar.Tank_Size);
            cmd.Parameters.AddWithValue("@Fuel_Type", myCar.Fuel_Type);
            cmd.Parameters.AddWithValue("@HorsePower", myCar.HorsePower);
            cmd.Parameters.AddWithValue("@Torque", myCar.Torque);
            cmd.Parameters.AddWithValue("@Transmission", myCar.Transmission);
            cmd.Parameters.AddWithValue("@TimesViewed", myCar.TimesViewed);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
        static public void UpdateCar(Car myCar){
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @$"UPDATE CAR 
                            SET Make=@Make, Model=@Model, Trim=@Trim, Year=@Year, Deleted=@Deleted, Gas_Mileage=@Gas_Mileage, Tank_Size=@Tank_Size, Fuel_Type=@Fuel_Type, HorsePower=@HorsePower, Torque=@Torque, Transmission=@Transmission, TimesViewed=@TimesViewed
                            WHERE CarID=@CarID";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@Make", myCar.Make);
            cmd.Parameters.AddWithValue("@Model", myCar.Model);
            cmd.Parameters.AddWithValue("@Trim", myCar.Trim);
            cmd.Parameters.AddWithValue("@Year", myCar.Year);
            cmd.Parameters.AddWithValue("@Deleted", myCar.Deleted);
            cmd.Parameters.AddWithValue("@Gas_Mileage", myCar.Gas_Mileage);
            cmd.Parameters.AddWithValue("@Tank_Size", myCar.Tank_Size);
            cmd.Parameters.AddWithValue("@Fuel_Type", myCar.Fuel_Type);
            cmd.Parameters.AddWithValue("@HorsePower", myCar.HorsePower);
            cmd.Parameters.AddWithValue("@Torque", myCar.Torque);
            cmd.Parameters.AddWithValue("@Transmission", myCar.Transmission);
            cmd.Parameters.AddWithValue("@TimesViewed", myCar.TimesViewed);
            cmd.Parameters.AddWithValue("@CarID", myCar.CarID);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
    }
}