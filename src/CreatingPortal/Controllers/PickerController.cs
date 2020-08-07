using Microsoft.AspNetCore.Mvc;

namespace CreatingPortal.Controllers
{
    public class PickerController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
