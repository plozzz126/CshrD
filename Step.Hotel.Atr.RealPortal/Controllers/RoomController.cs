using Microsoft.AspNetCore.Mvc;
using Step.Hotel.Atr.RealPortal.Models;

namespace Step.Hotel.Atr.RealPortal.Controllers
{
    public class RoomController : Controller
    {
        private readonly AppDbContext db;

        public RoomController(AppDbContext context)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var rooms = db.R_Rooms.ToList();
            return View();
        }

        public IActionResult RoomDetails()
        {
            List<R_Room> RoomD = db.R_Rooms.ToList();
            
            return View(RoomD);
        }
    }
}
