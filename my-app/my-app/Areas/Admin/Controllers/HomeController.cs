using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_app.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult Shop()
        {
            return View();
        }
    }
}
