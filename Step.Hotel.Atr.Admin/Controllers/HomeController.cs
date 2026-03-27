using Microsoft.AspNetCore.Mvc;
using Step.Hotel.Atr.Admin.Data;
using Step.Hotel.Atr.Admin.Models;
using System.Diagnostics;

namespace Step.Hotel.Atr.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HotelAtrDbContext _db;
        public HomeController(ILogger<HomeController> logger, HotelAtrDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TeamList()
        {
            List<RTeam> data = _db.RTeams.ToList();
            return View(data);
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
    }
}
