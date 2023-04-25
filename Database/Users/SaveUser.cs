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

            string stm = @"INSERT INTO USER(UserName, Password, UserEmail, FirstName, LastName, State, DateJoined, Role_ID)
                            VALUES(@UserName, @Password, @UserEmail, @FirstName, @LastName, @State, @DateJoined, @Role_ID)";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@UserName", myUser.UserName);
            cmd.Parameters.AddWithValue("@Password", myUser.Password);
            cmd.Parameters.AddWithValue("@UserEmail", myUser.UserEmail);
            cmd.Parameters.AddWithValue("@FirstName", myUser.FirstName);
            cmd.Parameters.AddWithValue("@LastName", myUser.LastName);
            cmd.Parameters.AddWithValue("@State", myUser.State);
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

            string stm = @$"UPDATE USER 
                            SET UserName=@UserName, Password=@Password, UserEmail=@UserEmail,FirstName=@FirstName, LastName=@LastName, State=@State, DateJoined=@DateJoined, Role_ID=@Role_ID
                            WHERE User_ID=@User_ID";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@UserName", myUser.UserName);
            cmd.Parameters.AddWithValue("@Password", myUser.Password);
            cmd.Parameters.AddWithValue("@UserEmail", myUser.UserEmail);
            cmd.Parameters.AddWithValue("@FirstName", myUser.FirstName);
            cmd.Parameters.AddWithValue("@LastName", myUser.LastName);
            cmd.Parameters.AddWithValue("@State", myUser.State);
            cmd.Parameters.AddWithValue("@DateJoined", myUser.DateJoined);
            cmd.Parameters.AddWithValue("@Role_ID", myUser.Role_ID);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
    }
}