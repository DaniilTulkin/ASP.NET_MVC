using ASP.NET_MVC.Data;
using Microsoft.AspNetCore.Mvc;

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
    }
}
