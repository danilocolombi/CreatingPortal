using CreatingPortal.Models.Unscrambles;
using CreatingPortal.Services;
using CreatingPortal.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CreatingPortal.Controllers
{
    [Route("Unscramble")]
    public class UnscrambleController : Controller
    {
        private readonly UnscrambleService _unscrambleService;

        public UnscrambleController()
        {
            _unscrambleService = new UnscrambleService(Config.API_BASE_ADDRESS);
        }

        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        [Route("edit")]
        public async Task<IActionResult> Edit(int id)
        {
            var unscramble = await _unscrambleService.GetAsync(id);

            return View(unscramble);
        }

        [Route("play")]
        public async Task<IActionResult> Play(int id)
        {
            var unscramble = await _unscrambleService.GetShuffledExercisesAsync(id);

            return View(unscramble);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UnscrambleCreationViewModel unscramble)
        {
            try
            {
                var resultCreatedUnscramble = await _unscrambleService.CreateAsync(unscramble);

                if (!resultCreatedUnscramble.Success) 
                    return Json(new { error = true, message = resultCreatedUnscramble.Errors });

                return Json(new { error = false });
            }
            catch (Exception ex)
            {
                return Json(new { error = true, message = ex.Message });
            }
        }

        [HttpPut("[controller]/[action]/{unscrambleId:int}")]
        public async Task<IActionResult> Edit(int unscrambleId, [FromBody] UnscrambleCreationViewModel unscramble)
        {
            try
            {
                var resultCreatedUnscramble = await _unscrambleService.UpdateAsync(unscrambleId, unscramble);

                if (!resultCreatedUnscramble.Success)
                    return Json(new { error = true, message = resultCreatedUnscramble.Errors });

                return Json(new { error = false });
            }
            catch (Exception ex)
            {
                return Json(new { error = true, message = ex.Message });
            }
        }

    }
}
