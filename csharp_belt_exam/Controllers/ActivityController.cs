using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using csharp_belt_exam.Models;
using System.Collections.Generic;

namespace csharp_belt_exam.Controllers
{
    [Route("activity")]
    public class ActivityController : Controller
    {
        private int? UserSession
        {
            get { return HttpContext.Session.GetInt32("UserId"); }
            set { HttpContext.Session.SetInt32("UserId", (int)value); }
        }
        private MyContext dbContext;
        public ActivityController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            // Redirect to register/login page if no user in session
            if (UserSession == null)
                return RedirectToAction("Index", "Home");

            // Get all activites with included responses ordered by date
            var AllActivities = dbContext.Activities
                .Include(a => a.Participants)
                .OrderByDescending(a => a.Date)
                .ToList();

            ViewBag.UserId = UserSession;
            return View(AllActivities);
        }

        [HttpGet("{activityId}")]
        public IActionResult Show(int activityId)
        {
            var thisActivity = dbContext.Activities
            .Include(a => a.Participants)
            .ThenInclude(p => p.Person)
            .FirstOrDefault(a => a.ActivityId == activityId);
            
            return View(thisActivity);
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Activity newActivity)
        {
            if (UserSession == null)
                    return RedirectToAction("Index", "Home");
            if (ModelState.IsValid)
            {   
                // Crete new activity with UserId set to current session user's id
                newActivity.UserId = (int)UserSession;
                dbContext.Activities.Add(newActivity);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            return View("New");
        }

        [HttpGet("delete")]
        public IActionResult Delete(int activityId)
        {
            if (UserSession == null)
                return RedirectToAction("Index", "Home");

            Activity toDelete = dbContext.Activities.FirstOrDefault(a => a.ActivityId == activityId);
            
            if (toDelete == null)
                return RedirectToAction("Dashboard");
            // Redirect to dashboard if user trying to delete isn't the activity creator
            if (toDelete.UserId != UserSession)
                return RedirectToAction("Dashboard");
            
            dbContext.Activities.Remove(toDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
    }
}