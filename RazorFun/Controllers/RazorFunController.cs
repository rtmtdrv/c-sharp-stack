using Microsoft.AspNetCore.Mvc;

namespace RazorFun.Controllers
{
    public class RazorFunController : Controller 
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}