using Microsoft.AspNetCore.Mvc;

namespace Step.Hotel.Atr.RealPortal.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RoomDetails()
        {
            return View();
        }
    }
}
