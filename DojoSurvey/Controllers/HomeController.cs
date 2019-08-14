using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;


namespace DojoSurvey
{
    public class HomeController : Controller 
    {
        [HttpGet("")]
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("result")]
        public ActionResult Result(string name, string location, string language, string textarea)
        {
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.textarea = textarea;

            return View();
        }

        //Redirect to Index if accessed through GET Request
        [HttpGet("result")]
        public RedirectToActionResult Redirect()
        {
            return RedirectToAction("Index");
        }
    }
}