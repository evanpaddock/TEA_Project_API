namespace TEA_Project_API
{
    public class ConnectionString
    {
        private string Server = @"hwr4wkxs079mtb19.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
        private string Username = "euxzcg6yn0uw8i7w";
        private string Password = "u5rktv5agvafabe3";
        private string Port = "3306";
        private string Database = "jspzik5rdmwk62p2";
        public string cs{get; set;}

        public ConnectionString(){
            cs = $@"server={Server}; user={Username}; database={Database}; port={Port}; password={Password};";
        }
    }
}