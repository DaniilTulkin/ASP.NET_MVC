using ASP.NET_MVC.Data;
using ASP.NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_MVC.Controllers
{
    public class RaceController : Controller
    {
        private readonly ApplicationDbContext context;

        public RaceController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var races = context.Races.ToList();
            return View(races);
        }

        public IActionResult Detail(int id)
        {
            Race race = context
                        .Races
                        .Include(c => c.Address)
                        .FirstOrDefault(c => c.Id == id);
            return View(race);
        }
    }
}
