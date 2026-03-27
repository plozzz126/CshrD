using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Step.Hotel.Atr.RealPortal.Models;

namespace Step.Hotel.Atr.RealPortal.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext db;
        public EventController(AppDbContext db)
        {
            this.db = db;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
