namespace TEA_Project_API.Models
{
    public class Car
    {
        public int CarID{get; set;}
        public string Make{get; set;}
        public string Model{get; set;}
        public string Trim{get; set;}
        public string Year{get; set;}
        public bool Deleted{get; set;}
        public string Gas_Mileage{get; set;}
        public string Tank_Size{get; set;}
        public string Fuel_Type{get; set;}
        public int HorsePower{get; set;}
        public int Torque{get; set;}
        public string Transmission{get; set;}
        public int TimesViewed{get; set;}
    }
}