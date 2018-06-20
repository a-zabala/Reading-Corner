using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reading_Corner.Models;

namespace Reading_Corner.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index(string id)
        {
            return View();
        }

      
        public IActionResult About()
        {
            ViewData["Message"] = "Welcome to Your Reading Corner";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "How to Contact Us";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
