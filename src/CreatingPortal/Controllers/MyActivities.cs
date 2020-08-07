using Microsoft.AspNetCore.Mvc;

namespace CreatingPortal.Controllers
{
    public class MyActivities : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
