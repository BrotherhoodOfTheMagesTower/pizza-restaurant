using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaRestaurant.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public int ClientID { get; set; }
        public int Profit { get; set; }
        public string Address { get; set; }
        public int Costs { get; set; }
        //public DateTime Date { get; set; }

    }
}
