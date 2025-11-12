using Cinema.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Controllers
{
    public class CinemaController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Rooms = DataCinema.RoomCapacity.Keys;
            ViewBag.Tickets = DataCinema.Tickets;
            return View();
        }

        [HttpPost]
        public IActionResult Book(string name, string lastName, string room, string type)
        {
            DataCinema.Tickets.Add(new Ticket
            {
                Name = name,
                LastName = lastName,
                Room = room,
                Type = type
            });
            return RedirectToAction("Index");
        }
    }
}