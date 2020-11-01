using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SonarCubeCodeQuality
{
    public class HomeController : Controller
    {
        //New Controller Introduced
        public IActionResult Index()
        {
            var abcd = 1234;
            return View();
        }
    }
}
