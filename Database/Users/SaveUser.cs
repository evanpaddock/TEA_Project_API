using MySql.Data.MySqlClient;
using TEA_Project_API.Models;

namespace TEA_Project_API.Database.Users
{
    public class SaveUser
    {
        static public void NewUser(User myUser){
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"INSERT INTO USER(UserName, Password, UserEmail, DateJoined, Role_ID)
                            VALUES(@UserName, @Password, @UserEmail, @DateJoined, @Role_ID)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@UserName", myUser.UserName);
            cmd.Parameters.AddWithValue("@Password", myUser.Password);
            cmd.Parameters.AddWithValue("@UserEmail", myUser.UserEmail);
            cmd.Parameters.AddWithValue("@DateJoined", myUser.DateJoined);
            cmd.Parameters.AddWithValue("@DateJoined", myUser.DateJoined);
            cmd.Parameters.AddWithValue("@Role_ID", myUser.Role_ID);
            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
        static public void UpdateUser(User myUser){
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @$"UPDATE User 
                            SET UserName=@UserName, Password=@Password, UserEmail=@UserEmail, DateJoined=@DateJoined, Role_ID=@Role_ID
                            WHERE UserID=@UserID";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@UserName", myUser.Make);
            cmd.Parameters.AddWithValue("@Password", myUser.Password);
            cmd.Parameters.AddWithValue("@UserEmail", myUser.UserEmail);
            cmd.Parameters.AddWithValue("@DateJoined", myUser.DateJoined);
            cmd.Parameters.AddWithValue("@Role_ID", myUser.Role_ID);
            cmd.Parameters.AddWithValue("@UserID", myUser.UserID);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
    }
}