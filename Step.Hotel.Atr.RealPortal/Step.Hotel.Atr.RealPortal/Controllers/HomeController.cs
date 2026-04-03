using Microsoft.AspNetCore.Mvc;
using Step.Hotel.Atr.RealPortal.Models;
using System.Diagnostics;

namespace Step.Hotel.Atr.RealPortal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
