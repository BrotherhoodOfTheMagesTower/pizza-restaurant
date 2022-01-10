using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaRestaurant.Models
{
    public class Crew
    {
        public List<int> WorkersIDS { get; set; }
        public int RestaurantID { get; set; }
    }
}
