using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SignUpGenius.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SignUpGenius.Models.ViewModels;

namespace SignUpGenius.Controllers
{
    public class HomeController : Controller
    {
        private ISignUpGeniusRepository repo;
        //dbcontext 
        private SignUpGeniusContext context { get; set; }
       

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
            var x = repo.FormResponses
                .Include(x => x.TimeSlot)
                .OrderBy(x => x.TimeSlot)
                .ToList();

            return View(x);
        }


        public IActionResult SelectTime()
        {
            var t = repo.TimeSlots
                .Where(t => t.Taken == false)
                .OrderBy(t => t.TourTime);

            return View();
        }


        //i think here is where we will pass in the time.. SignUP(time)
        [HttpGet]
        public IActionResult SignUp( int TimeId)
        {
            ViewBag.TimeSlot = repo.TimeSlots.ToList();
            return View(new AppTimeViewModel
            {
                timeSlot = context.TimeSlots.Single( t => t.TimeSlotID = TimeId)
                // this we can finish once we have the context file set up at the top of this page 
            }
                );
        }


        [HttpPost]
        public IActionResult SignUp(FormResponse fr)
        {
            if (ModelState.IsValid)
            {
                repo.SaveResponse(fr);

                return View("Confirmation", fr);
            }
            else
            {
                return View(fr);
            }
        }

        [HttpGet]
        public IActionResult Edit(int tourid)
        {
            ViewBag.TimeSlot = repo.TimeSlots.ToList();

            var entry = repo.FormResponses.Single(x => x.TourId == tourid);

            return View("SignUp", entry);
        }

        [HttpPost]
        public IActionResult Edit(FormResponse fr)
        {
            repo.SaveResponse(fr);

            return RedirectToAction("ViewApp");
        }

        [HttpGet]
        public IActionResult Delete(int tourid)
        {
            var entry = repo.FormResponses.Single(x => x.TourId == tourid);

            return View(entry);
        }

        [HttpPost]
        public IActionResult Delete(FormResponse fr)
        {
            repo.DeleteResponse(fr);

            return RedirectToAction("ViewApp");
        }


    }
}
