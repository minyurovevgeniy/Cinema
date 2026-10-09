using AuditoriumManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AuditoriumManagement.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ChooseSeat()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult ChooseSeat(string seat)
        {
            string mySeat = seat;
            return ChooseSeat();
        }
    }
}
