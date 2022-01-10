using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaRestaurant.Models
{
    public class Account
    {
        public int AccountID { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public DateTime CreationDate { get; set; }
        public int PromotionPoints { get; set; }
    }
}
