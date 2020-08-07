using Microsoft.AspNetCore.Mvc;

namespace CreatingPortal.Controllers
{
    public class TicTacToeController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
