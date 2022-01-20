using PizzaRestaurant.Models;
using System.Collections.Generic;

namespace PizzaRestaurant.ViewModels
{
    public class IndexModel
    {
        public List<Models.Pizza> Pizzas { get; private set; }

        public IndexModel(List<Pizza> pizzas)
        {
            Pizzas = pizzas;
        }
    }
}
