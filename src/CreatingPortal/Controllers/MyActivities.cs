using CreatingPortal.Services;
using CreatingPortal.Utilities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CreatingPortal.Controllers
{
    [Route("my-activities")]
    public class MyActivities : Controller
    {
        private readonly UserService _userService;

        public MyActivities()
        {
            _userService = new UserService(Config.API_BASE_ADDRESS);
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Activities = await _userService.GetUserActivitiesAsync(1);

            return View();
        }

        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }
    }
}
