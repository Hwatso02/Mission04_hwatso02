using Microsoft.AspNetCore.Mvc;
using Mission04_hwatso02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_hwatso02.Controllers
{
    public class cshtmlController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Get for form
        [HttpGet]
        public IActionResult GradeCalculator()
        {
            return View();
        }

        //Post for form
        [HttpPost]
        public IActionResult GradeCalculator(GradeCalculatorModel model)
        {
            return View();
        }
    }
}
