using Microsoft.AspNetCore.Mvc;
using PartialViewInAspCore8.Models;
using System.Diagnostics;

namespace PartialViewInAspCore8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Products()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){Id=101,Name="Reebok shoes",Description="Description 1",Price=10000.00,Image="~/images/REEBOK.jfif"},
                 new Product(){Id=102,Name="Reyben Glass",Description="Description 2",Price=20000.00,Image="~/images/REYBEN.jfif"}, 
                  new Product(){Id=103,Name="Rolex watch",Description="Description 3",Price=30000.00,Image="~/images/ROLEX.jfif"},

            };
            return View(products);
        }

        public IActionResult Privacy()
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
