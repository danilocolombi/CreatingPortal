using Microsoft.AspNetCore.Mvc;

namespace CreatingPortal.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
