using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaRestaurant.Models
{
    public class Pizza
    {
        public int PizzaID { get; set; }
        public int RestaurantID { get; set; }
        public int Price { get; set; }
        public int Points { get; set; }
        public int Size { get; set; }
        public List<string> Ingredients  { get; set; }
        public bool Availiability { get; set; }
    }
}
