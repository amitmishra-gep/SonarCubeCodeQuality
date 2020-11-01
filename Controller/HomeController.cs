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
            return View();
        }

        //Require to much code smells
        public IActionResult Additiona(int a, int b)
        {
            return Ok(a + b);
        }

        //Require to much code smells
        public IActionResult Additionb(int a, int b)
        {
            return Ok(a + b);
        }
    }
}
