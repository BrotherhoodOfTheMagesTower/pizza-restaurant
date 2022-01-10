using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaRestaurant.Models
{
    public class CompanyCar
    {
        public int CarID { get; set; }
        public string CarRegistration { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Expenses { get; set; }
    }
}
