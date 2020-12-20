using Microsoft.AspNetCore.Mvc;

namespace CreatingPortal.Controllers
{
    [Route("tictactoe")]
    public class TicTacToeController : Controller
    {
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        [Route("edit")]
        public IActionResult Edit()
        {
            return View();
        }

        [Route("play")]
        public IActionResult Play()
        {
            return View();
        }
    }
}
