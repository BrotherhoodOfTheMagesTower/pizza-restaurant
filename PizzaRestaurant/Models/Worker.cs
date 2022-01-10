using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaRestaurant.Models
{
    public class Worker:Account
    {
        public int WorkerID { get; set; }
        public int Salary { get; set; }
        public double Discount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
