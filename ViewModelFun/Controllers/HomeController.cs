using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string str = "Pariatur cupidatat voluptate occaecat cillum ad cupidatat ut eiusmod laborum.";
            return View("Index", str);
        }
        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = { 1, 2, 3, 10, 43, 5 };
            return View("Numbers", numbers);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            List<User> names = new List<User>();
            User Art = new User("Art", "Todorov");
            User Homer = new User ("Homer", "Simpson");
            User Peter = new User ("Peter", "Griffin");

            names.Add(Art);
            names.Add(Homer);
            names.Add(Peter);

            return View("Users", names);
 
        }

        [HttpGet("user")]
        public new IActionResult User()
        {
            User name = new User("Art", "Todorov");
            return View("SingleUser", name);
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
