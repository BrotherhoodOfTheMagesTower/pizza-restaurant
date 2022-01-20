using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaRestaurant.Data;
using PizzaRestaurant.Models;
using PizzaRestaurant.ViewModels;
using System.Diagnostics;
using System.Linq;

namespace PizzaRestaurant.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var pizzas = _context
                .Pizza
                .Where(c => c.Availiability == true)
                .ToList();

            if (pizzas.Count == 0)
            {
                _context.Pizza.Add(new Pizza(1, "Margherita", 23, 5, 32, true));
                _context.Pizza.Add(new Pizza(1, "Funghi", 15, 2, 32, true));
                _context.Pizza.Add(new Pizza(1, "Capriciosa", 25, 6, 32, true));
                _context.Pizza.Add(new Pizza(1, "Parma", 22, 4, 32, true));
                _context.Pizza.Add(new Pizza(1, "Campione", 24, 5, 32, true));
                _context.Pizza.Add(new Pizza(1, "Napoletana", 23, 5, 32, true));
                _context.Pizza.Add(new Pizza(1, "Roma", 26, 6, 32, true));
                _context.Pizza.Add(new Pizza(1, "Pepperoni", 25, 5, 32, true));
                _context.Pizza.Add(new Pizza(1, "Havai", 23, 4, 32, true));
                _context.Pizza.Add(new Pizza(1, "Bianco", 26, 6, 32, true));
                _context.Pizza.Add(new Pizza(1, "Prosciutto", 23, 4, 32, true));
                _context.Pizza.Add(new Pizza(1, "Quattro formaggi", 25, 5, 32, true));
                _context.Pizza.Add(new Pizza(1, "Vegano", 26, 6, 32, true));
                _context.Pizza.Add(new Pizza(1, "Gangsterska", 28, 7, 32, true));
                _context.Pizza.Add(new Pizza(1, "Pokerowa", 25, 6, 32, true));
                _context.SaveChanges();
            }

            return View(new IndexModel(pizzas));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Order()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
