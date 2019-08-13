using Microsoft.AspNetCore.Mvc;

namespace Portfolio2.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.hello = "Hello world!";
            return View("Index");
        }

        [HttpGet("projects")]
        public IActionResult Portfolio()
        {
            return View("Projects");
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View("Contact");
        }
    }
}