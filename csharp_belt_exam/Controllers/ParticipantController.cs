using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace csharp_belt_exam.Models
{
    [Route("participant")]
    public class ParticipantController : Controller
    {
        private int? UserSession 
        {
            get { return HttpContext.Session.GetInt32("UserId"); }
            set { HttpContext.Session.SetInt32("userId", (int)value); }
        }
        private MyContext dbContext;
        public ParticipantController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("join/{activityId}")]
        public IActionResult Join(int activityId)
        {
            if (UserSession == null)
                return RedirectToAction("Index", "Home");
            
            // Create a new particiapnt with the given activityId and current userId
            Participant newParticipant = new Participant()
            {
                ActivityId = activityId,
                UserId = (int)UserSession
            };
            dbContext.Participants.Add(newParticipant);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard", "Activity");
        }

        [HttpGet("leave/{activityId}")]
        public IActionResult Leave(int activityId)
        {
            if (UserSession == null)
                return RedirectToAction("Index", "Home");

            // Query to grab the appropriate response to remove
            Participant toDelete = dbContext.Participants.FirstOrDefault(p => p.ActivityId == activityId && p.UserId == UserSession);

            // Redirect to dashboard if no match for response in db
            if (toDelete == null)
                return RedirectToAction("Dashboard", "Activity");

            dbContext.Participants.Remove(toDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard", "Activity");
        }
    }
}