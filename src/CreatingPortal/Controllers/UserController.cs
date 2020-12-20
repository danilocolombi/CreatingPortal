using Microsoft.AspNetCore.Mvc;

namespace CreatingPortal.Controllers
{
    [Route("user")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
