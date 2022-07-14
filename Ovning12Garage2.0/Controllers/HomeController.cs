using Microsoft.AspNetCore.Mvc;
using Ovning12Garage2._0.Models;
using System.Diagnostics;

namespace Ovning12Garage2._0.Controllers
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

        //public IActionResult Start()
        //{
        //    return View();
        //}

        //public IActionResult SearchVehicle()
        //{
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        //public IActionResult Receipt()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}