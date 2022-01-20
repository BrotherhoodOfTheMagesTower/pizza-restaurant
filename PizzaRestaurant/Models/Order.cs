using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaRestaurant.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int ClientID { get; set; }
        [NotMapped]
        public List<int> PizzaIDS { get; set; }
        public int RestaurantID { get; set; }
        public bool Confirmation { get; set; }
        public DateTime OrderDate { get; set; }
        public string DeliveryAddress { get; set; }


    }
}
