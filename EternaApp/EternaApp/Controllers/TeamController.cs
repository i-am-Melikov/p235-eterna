using Microsoft.AspNetCore.Mvc;

namespace EternaApp.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
