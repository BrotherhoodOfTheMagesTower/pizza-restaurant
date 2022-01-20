namespace PizzaRestaurant.Models
{
    public class Table
    {
        public int TableID { get; set; }
        public int RestaurantID { get; set; }
        public int ClientID { get; set; }
        public int Capacity { get; set; }// pojemnosc stolika
        public int Occupancy { get; set; }// aktualne oblozenie stolika
    }
}
