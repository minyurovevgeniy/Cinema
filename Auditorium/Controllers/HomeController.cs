using AuditoriumManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ApplicationDbContext db = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>());
            int row = int.Parse(seat.Split('_')[0]);
            int place = int.Parse(seat.Split('_')[1]);

            Auditorium room = new Auditorium();
            room.AuditoriumNumber = 2;

            Seat seatToAdd = new Seat();

            seatToAdd.Row = row;
            seatToAdd.Place = place;

            seatToAdd.Auditorium = room;

            db.Auditoriums.Add(room);
            db.Seats.Add(seatToAdd);

            db.SaveChanges();

            return ChooseSeat();
        }
    }
}
