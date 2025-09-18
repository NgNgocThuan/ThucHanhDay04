using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ThucHanhDay04.Models;

namespace ThucHanhDay04.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        Product products = new Product();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

        public IActionResult About()
        {
            var model = products.GetListProduct();
            return View(model);
        }

        public IActionResult Order()
        {
            return View();
        }
    }
}
