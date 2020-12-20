using CreatingPortal.Models.Pickers;
using CreatingPortal.Services;
using CreatingPortal.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CreatingPortal.Controllers
{
    [Route("picker")]
    public class PickerController : Controller
    {

        private readonly PickerService _pickerService;

        public PickerController()
        {
            _pickerService = new PickerService(Config.API_BASE_ADDRESS);
        }

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

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PickerCreationViewModel picker)
        {
            try
            {
                var resultCreatedPicker = await _pickerService.CreateAsync(picker);

                if (!resultCreatedPicker.Success)
                    return Json(new { error = true, message = resultCreatedPicker.Errors });

                return Json(new { error = false });
            }
            catch (Exception ex)
            {
                return Json(new { error = true, message = ex.Message });
            }
        }
    }
}
