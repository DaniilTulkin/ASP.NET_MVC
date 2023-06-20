using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
