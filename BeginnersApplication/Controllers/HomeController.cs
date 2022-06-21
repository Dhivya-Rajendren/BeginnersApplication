using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeginnersApplication.Controllers
{
    public class HomeController : Controller
    {
        //  home/index


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            string[] names = { "Dhivya", "Swetha", "Viji", "Kala" };
            return Json(new { id = 1, name = "Dhivya" });
        }
    }
}
