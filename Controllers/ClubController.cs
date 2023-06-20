using ASP.NET_MVC.Data;
using ASP.NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public IActionResult Detail(int id)
        {
            Club club = context
                        .Clubs
                        .Include(c => c.Address)
                        .FirstOrDefault(c => c.Id == id);
            return View(club);
        }
    }
}
