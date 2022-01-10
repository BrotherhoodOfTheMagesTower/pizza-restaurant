using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
