namespace TEA_Project_API.Models
{
    public class User
    {
        public int User_ID{get; set;}
        public string UserName{get; set;}
        public string Password{get; set;}
        public string UserEmail{get; set;}
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public DateOnly DateJoined{get; set;}
        public string State{get; set;}
        public int Role_ID{get; set;}
    }
}