using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WeddingPlanner.Models 
{
    [Route("response")]
    public class ResponseController : Controller
    {
        private int? UserSession 
        {
            get { return HttpContext.Session.GetInt32("UserId"); }
            set { HttpContext.Session.SetInt32("userId", (int)value); }
        }
        private MyContext dbContext;
        public ResponseController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("rsvp/{weddingId}")]
        public IActionResult RSVP(int weddingId)
        {
            if (UserSession == null)
                return RedirectToAction("Index", "Home");
            
            // Create a new response with the given weddingId and current userId
            Response newResponse = new Response()
            {
                WeddingId = weddingId,
                UserId = (int)UserSession
            };
            dbContext.Responses.Add(newResponse);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard", "Wedding");
        }

        [HttpGet("unrsvp/{weddingId}")]
        public IActionResult UnRSVP(int weddingId)
        {
            if (UserSession == null)
                return RedirectToAction("Index", "Home");

            // Query to grab the appropriate response to remove
            Response toDelete = dbContext.Responses.FirstOrDefault(r => r.WeddingId == weddingId && r.UserId == UserSession);

            // Redirect to dashboard if no match for response in db
            if (toDelete == null)
                return RedirectToAction("Dashboard", "Wedding");

            dbContext.Responses.Remove(toDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard", "Wedding");
        }
    }
}