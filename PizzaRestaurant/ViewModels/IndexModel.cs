using PizzaRestaurant.Models;
using System.Collections.Generic;

namespace PizzaRestaurant.ViewModels
{
    public class IndexModel
    {
        public string Name { get; private set; }
        public List<Models.Pizza> Pizzas { get; private set; }

        public IndexModel(string name, List<Pizza> pizzas)
        {
            Name = name;
            Pizzas = pizzas;
        }
    }
}
