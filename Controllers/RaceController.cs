using ASP.NET_MVC.Interfaces;
using ASP.NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC.Controllers
{
    public class RaceController : Controller
    {
        private readonly IRaceService raceService;

        public RaceController(IRaceService raceService)
        {
            this.raceService = raceService;
        }

        public async Task<IActionResult> Index()
        {
            var races = await raceService.GetAllAsync();
            return View(races);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Race race = await raceService.GetByIdAsync(id);
            return View(race);
        }
    }
}
