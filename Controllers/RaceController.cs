using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
