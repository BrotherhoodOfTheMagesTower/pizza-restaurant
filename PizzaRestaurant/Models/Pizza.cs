using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaRestaurant.Models
{
    public class Pizza
    {
        public int PizzaID { get; private set; }
        public int RestaurantID { get; private set; }
        public int Price { get; private set; }
        public int Points { get; private set; }
        public int Size { get; private set; }
        [NotMapped]
        public List<string> Ingredients  { get; private set; }
        public bool Availiability { get; private set; }

        public Pizza()
        {
        }

        public Pizza(int pizzaID, int restaurantID, int price, int points, int size, List<string> ingredients, bool availiability)
        {
            PizzaID = pizzaID;
            RestaurantID = restaurantID;
            Price = price;
            Points = points;
            Size = size;
            Ingredients = ingredients;
            Availiability = availiability;
        }
    }
}
