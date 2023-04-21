using MySql.Data.MySqlClient;
using TEA_Project_API.Models;

namespace TEA_Project_API.Database.Roles
{
    public class SaveRoles
    {
        static public void NewRole(Role myRole){
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            //Creates Role
            string stm = @" INSERT INTO ROLE(RoleName, Edit_Page_TF, Reports_Able_TF, Admin_Page_TF, User_Page_TF)
                            VALUES(@RoleName, @Edit_Page_TF, @Reports_Able_TF, @Admin_Page_TF, @User_Page_TF);";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@RoleName", myRole.RoleName);
            cmd.Parameters.AddWithValue("@Edit_Page_TF", myRole.Edit_Page_TF);
            cmd.Parameters.AddWithValue("@Reports_Able_TF", myRole.Reports_Able_TF);
            cmd.Parameters.AddWithValue("@Admin_Page_TF", myRole.Admin_Page_TF);
            cmd.Parameters.AddWithValue("@User_Page_TF", myRole.User_Page_TF);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
        static public void UpdateRole(Role myRole){
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @$"UPDATE ROLE
                            SET RoleName=@RoleName, Edit_Page_TF=@Edit_Page_TF, Reports_Able_TF=@Reports_Able_TF, 
                            Admin_Page_TF=@Admin_Page_TF, User_Page_TF=@User_Page_TF
                            WHERE Role_ID=@Role_ID";

            using var cmd = new MySqlCommand(stm, con);

            cmd.Parameters.AddWithValue("@RoleName", myRole.RoleName);
            cmd.Parameters.AddWithValue("@Edit_Page_TF", myRole.Edit_Page_TF);
            cmd.Parameters.AddWithValue("@Reports_Able_TF", myRole.Reports_Able_TF);
            cmd.Parameters.AddWithValue("@Admin_Page_TF", myRole.Admin_Page_TF);
            cmd.Parameters.AddWithValue("@User_Page_TF", myRole.User_Page_TF);
            cmd.Parameters.AddWithValue("@Role_ID", myRole.Role_ID);

            cmd.Prepare();

            cmd.ExecuteNonQuery();
        }
    }
}