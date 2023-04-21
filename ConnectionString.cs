namespace TEA_Project_API
{
    public class ConnectionString
    {
        private string Server = @"nnsgluut5mye50or.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
        private string Username = "e7tekk1teqz6b6t1";
        private string Password = "ditq7wb2pz6zto7e";
        private string Port = "3306";
        private string Database = "naqovhbrkkdsvlao";
        public string cs{get; set;}

        public ConnectionString(){
            cs = $@"server={Server}; user={Username}; database={Database}; port={Port}; password={Password};";
        }
    }
}