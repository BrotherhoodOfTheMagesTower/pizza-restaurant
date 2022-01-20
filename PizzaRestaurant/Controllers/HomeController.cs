using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaRestaurant.Data;
using PizzaRestaurant.Models;
using PizzaRestaurant.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

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

            return View(new IndexModel("Test", pizzas));
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
