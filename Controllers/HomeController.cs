using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SignUpGenius.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpGenius.Controllers
{
    public class HomeController : Controller
    {
        private ISignUpGeniusRepository repo;

        public HomeController(ISignUpGeniusRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewApp()
        {
            return View();
        }

        public IActionResult SelectTime()
        {
            return View();
        }

        //i think here is where we will pass in the time.. SignUP(date, time)
        [HttpGet]
        public IActionResult SignUp()
        {

            return View();
        }

        [HttpPost]
        public IActionResult SignUp(FormResponse fr)
        {
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
