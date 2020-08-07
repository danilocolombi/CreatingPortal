using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CreatingPortal.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
