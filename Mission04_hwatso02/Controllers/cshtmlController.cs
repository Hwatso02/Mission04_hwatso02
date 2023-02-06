using Microsoft.AspNetCore.Mvc;
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
    }
}
