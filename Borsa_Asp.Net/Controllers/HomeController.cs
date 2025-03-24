using Borsa_Asp.Net.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Borsa_Asp.Net.Controllers
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
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }
        public IActionResult Assets()
        {
            return View();
        }
        public IActionResult CurrencyConverter()
        {
            return View();
        }
        public IActionResult LiveCharts()
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
