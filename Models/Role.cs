namespace TEA_Project_API.Models
{
    public class Role
    {
        public int? Role_ID{get; set;}
        public string RoleName{get; set;}
        public bool Edit_Page_TF{get; set;}
        public bool Reports_Able_TF{get; set;}
        public bool Admin_Page_TF{get; set;}
        public bool User_Page_TF{get; set;}
    }
}