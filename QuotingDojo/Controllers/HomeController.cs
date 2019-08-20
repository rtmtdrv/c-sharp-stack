using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using QuotingDojo.Models;

namespace QuotingDojo.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("quotes")]
        public IActionResult CreateQuote(Quote newQuote)
        {
            if(ModelState.IsValid)
            {
                string query = $"INSERT INTO quotes (name, quotes) VALUES ('{newQuote.Name}', '{newQuote.Content}')";
                DbConnector.Execute(query);
                return RedirectToAction("GetQuotes");
            }
            return View("Index");
        }

        [HttpGet("quotes")]
        public IActionResult GetQuotes()
        {
            List<Dictionary<string, object>> AllQuotes = DbConnector.Query("SELECT * FROM quotes ORDER BY created_at DESC");
            ViewBag.Quotes = AllQuotes;
            return View("Quotes");
        }
    }
}
