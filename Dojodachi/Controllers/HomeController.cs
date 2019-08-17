using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Dojodachi.Models;
using Microsoft.AspNetCore.Http;

namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        // Setting pet into session
        private void SetSessionPet(Pet myPet = null)
        {
            if(myPet == null)
                myPet = new Pet();
            HttpContext.Session.SetInt32("fullness", myPet.Fullness);
            HttpContext.Session.SetInt32("happiness", myPet.Happiness);
            HttpContext.Session.SetInt32("meals", myPet.Meals);
            HttpContext.Session.SetInt32("energy", myPet.Energy);
        }

        // Get pet from session with the updated stats
        private Pet GetSessionPet()
        {
            return new Pet
            (
                HttpContext.Session.GetInt32("fullness"),
                HttpContext.Session.GetInt32("happiness"),
                HttpContext.Session.GetInt32("meals"),
                HttpContext.Session.GetInt32("energy")
            );
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {   
            // Check if there's a pet in session
            if(GetSessionPet() == null)
                SetSessionPet();
            // Check if dojodachi meets win conditions
            if (GetSessionPet().Won())
            {
                TempData["result"] = "Congratulations! You Won!";
                TempData["image"] = "https://media.giphy.com/media/U2nN0ridM4lXy/giphy.gif";
                ViewBag.Result = (string)TempData["result"];
                ViewBag.PetImage = (string)TempData["image"];
                return View("Won", GetSessionPet());
            }
            // Checks if dojodachi meets lose conditions
            if (GetSessionPet().Lost())
            {
                TempData["result"] = "Your Dojodachi has passed away";
                TempData["image"] = "https://media.giphy.com/media/iK4rg28Vg3A6Q/giphy.gif";
                ViewBag.Result = (string)TempData["result"];
                ViewBag.PetImage = (string)TempData["image"];
                return View("Lost", GetSessionPet());
            }
            // Set TempData to defaults if nothing has been stored yet
            if (TempData["result"] == null)
                TempData["result"] = "Let's Get Started!";
            if (TempData["image"] == null)
                TempData["image"] = "https://media.giphy.com/media/jXOxSiAx5UVnq/giphy.gif";
            ViewBag.Result = (string)TempData["result"];
            ViewBag.PetImage = (string)TempData["image"];
            return View(GetSessionPet());
        }

        [HttpGet("feed")]
        public IActionResult Feed()
        {
            // Getting pet from session
            Pet myPet = GetSessionPet();
            // Using feed method/storing it in a variable
            TempData["result"] = myPet.Feed();
            // Updating session with the modified stats
            SetSessionPet(myPet);
            // Display different images based on dojodachis response
            if ((string)TempData["result"] == "Your Dojodachi didn't like that. Fullness +0, Meals -1")
                TempData["Image"] = "https://media.giphy.com/media/eOsAHsDtyes36/giphy.gif";
            return RedirectToAction("Index");
        }

        [HttpGet("play")]
        public IActionResult Play()
        {
            Pet myPet = GetSessionPet();
            TempData["result"] = myPet.Play();
            SetSessionPet(myPet);
            if((string)TempData["result"] == "Your Dojodachi didn't feel like playing. Happiness +0, Energy -5")
                TempData["image"] = "https://media.giphy.com/media/khMwtd5muCbK0/giphy.gif";
            else
                TempData["image"] = "https://media.giphy.com/media/13G7hmmFr9yuxG/source.gif";
            return RedirectToAction("Index");
        }

        [HttpGet("work")]
        public IActionResult Work()
        {
            Pet myPet = GetSessionPet();
            TempData["result"] = myPet.Work();
            SetSessionPet(myPet);
            TempData["image"] = "https://media.giphy.com/media/l3n2pVYnj11hm/giphy.gif";
            return RedirectToAction("Index");
        }

        [HttpGet("sleep")]
        public IActionResult Sleep()
        {
            Pet myPet = GetSessionPet();
            TempData["result"] = myPet.Sleep();
            SetSessionPet(myPet);
            TempData["image"] = "https://media.giphy.com/media/13TKQw9VGugKuA/giphy.gif";
            return RedirectToAction("Index");
        }

        [HttpGet("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
