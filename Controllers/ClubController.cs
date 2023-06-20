using ASP.NET_MVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC.Controllers
{
    public class ClubController : Controller
    {
        private readonly ApplicationDbContext context;

        public ClubController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var clubs = context.Clubs.ToList();
            return View(clubs);
        }
    }
}
