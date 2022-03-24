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
                .ToList();

            return View(x);
        }


        public IActionResult SelectTime()
        {
            var x = repo.TimeSlots
                .Where(x => x.Taken == false)
                .ToList();

            return View(x);
        }


        //i think here is where we will pass in the time.. SignUP(time)
        [HttpGet]
        public IActionResult SignUp(int timeid)
        {
            //ViewBag.TimeSlot = repo.TimeSlots.ToList();
            //var timeSlot = context.TimeSlots.Single(x => x.TimeSlotID == timeid);

            var timeSlot = repo.TimeSlots
                .Single(x => x.TimeSlotID == timeid);

            var form = new FormResponse();
            form.TimeSlot = timeSlot;
            form.TimeSlotID = timeid;

            return View("SignUp", form);

            //ViewBag.TimeSlot = repo.TimeSlots.ToList();
            //return View(new AppTimeViewModel
            //{
            //    timeSlot = context.TimeSlots.Single(x => x.TimeSlotID == timeid)
            //    // this we can finish once we have the context file set up at the top of this page 
            //}
            //    );
        }


        [HttpPost]
        public IActionResult SignUp(FormResponse fr)
        {
            if (ModelState.IsValid)
            {
                //fr.TimeSlot.Taken = true;
                repo.AddResponse(fr);

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

            //var timeSlot = repo.TimeSlots
            //    .Single(x => x.TimeSlotID == timeid);


            var entry = repo.FormResponses.Single(x => x.TourId == tourid);

            return View("SignUp", entry);

            //ViewBag.TimeSlot = repo.TimeSlots.ToList();

            //var entry = repo.FormResponses.Single(x => x.TourId == tourid);

            //return View("SignUp", entry);
        }

        [HttpPost]
        public IActionResult Edit(FormResponse fr)
        {
            repo.EditResponse(fr);

            return RedirectToAction("ViewApp");
        }

        //[HttpGet]
        //public IActionResult Delete(int tourid)
        //{
        //    var entry = repo.FormResponses.Single(x => x.TourId == tourid);

        //    return View(entry);
        //}

        //[HttpPost]
        public IActionResult Delete(FormResponse fr)
        {
            repo.DeleteResponse(fr);

            return RedirectToAction("ViewApp");
        }


    }
}
