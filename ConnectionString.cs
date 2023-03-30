namespace TEA_Project_API
{
    public class ConnectionString
    {
        string Server = @"hwr4wkxs079mtb19.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
        string Username = "euxzcg6yn0uw8i7w";
        string Password = "u5rktv5agvafabe3";
        string Port = "3306";
        string Database = "jspzik5rdmwk62p2";
        public string cs{get; set;}

        public ConnectionString(){
            cs = $@"server={Server}; user={Username}; database={Database}; port={Port}; password={Password};";
        }
    }
}