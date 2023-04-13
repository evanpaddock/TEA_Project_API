using MySql.Data.MySqlClient;
using TEA_Project_API.Models;

namespace TEA_Project_API.Database.Roles
{
    public class SaveRoles
    {
        // static public void NewRole(Role myRole, RoleAbilities myAbilities){
        //     ConnectionString myConnection = new ConnectionString();
        //     string cs = myConnection.cs;
        //     using var con = new MySqlConnection(cs);
        //     con.Open();

        //     string stm = @"INSERT INTO ROLE(UserName, Password, UserEmail, DateJoined, Role_ID)
        //                     VALUES(@UserName, @Password, @UserEmail, @DateJoined, @Role_ID)";

        //     using var cmd = new MySqlCommand(stm, con);

        //     cmd.Parameters.AddWithValue("@UserName", myUser.UserName);
        //     cmd.Parameters.AddWithValue("@Password", myUser.Password);
        //     cmd.Parameters.AddWithValue("@UserEmail", myUser.UserEmail);
        //     cmd.Parameters.AddWithValue("@DateJoined", myUser.DateJoined.ToString());
        //     cmd.Parameters.AddWithValue("@Role_ID", myUser.Role_ID);
        //     cmd.Prepare();

        //     cmd.ExecuteNonQuery();
        // }
        // static public void UpdateUser(User myUser){
        //     ConnectionString myConnection = new ConnectionString();
        //     string cs = myConnection.cs;
        //     using var con = new MySqlConnection(cs);
        //     con.Open();

        //     string stm = @$"UPDATE USER 
        //                     SET UserName=@UserName, Password=@Password, UserEmail=@UserEmail, DateJoined=@DateJoined, Role_ID=@Role_ID
        //                     WHERE User_ID=@User_ID";

        //     using var cmd = new MySqlCommand(stm, con);

        //     cmd.Parameters.AddWithValue("@UserName", myUser.UserName);
        //     cmd.Parameters.AddWithValue("@Password", myUser.Password);
        //     cmd.Parameters.AddWithValue("@UserEmail", myUser.UserEmail);
        //     cmd.Parameters.AddWithValue("@DateJoined", myUser.DateJoined.ToString());
        //     cmd.Parameters.AddWithValue("@Role_ID", myUser.Role_ID);
        //     cmd.Parameters.AddWithValue("@User_ID", myUser.User_ID);

        //     cmd.Prepare();

        //     cmd.ExecuteNonQuery();
        // }
    }
}