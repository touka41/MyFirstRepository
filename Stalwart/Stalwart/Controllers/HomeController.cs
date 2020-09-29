using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stalwart.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //var obj = new { Id = 1, Name = "Phils" };

            //return View("AboutUs", obj);

            //return View("~/TempView/Phils.cshtml");
            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
