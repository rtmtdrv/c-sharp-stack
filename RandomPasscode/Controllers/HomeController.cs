using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomPasscode.Models;
using Microsoft.AspNetCore.Http;

namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        private string SessionPasscode
        {
            get {return HttpContext.Session.GetString("passcode");}
            set { HttpContext.Session.SetString("passcode", value);}
        }
        private int? SessionCount
        {
            get { return HttpContext.Session.GetInt32("count");}
            set { HttpContext.Session.SetInt32("count", (int)value); } 
        }

        public string GeneratePasscode()
        {
            string allowedCharacters = "ABCDEFJKLMNOPQRSTUVWXYZ1234567890";
            string newPass = "";
            Random rand = new Random();
            for(var i = 1; i < 15; i++)
                newPass += allowedCharacters[rand.Next(allowedCharacters.Length)];
            return newPass;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            if (SessionPasscode == null)
                SessionPasscode = "Generate Passcode";
            if (SessionCount == null)
                SessionCount = 0;

            ViewBag.Passcode = SessionPasscode;
            ViewBag.Count = SessionCount;
            return View();
        }
            
        [HttpPost("generate")]
        public IActionResult Generate()
        {
            SessionCount++;
            SessionPasscode = GeneratePasscode();
            return RedirectToAction("Index");
        }
        
        [HttpPost("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
