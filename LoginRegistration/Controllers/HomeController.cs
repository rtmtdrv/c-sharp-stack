using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginRegistration.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace LoginRegistration.Controllers
{
    public class HomeController : Controller
    {
        private int? UserSession
        {
            get { return HttpContext.Session.GetInt32("UserId"); }
            set { HttpContext.Session.SetInt32("UserId", (int)value); }
        }

        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if(ModelState.IsValid)
            {
                var existingUser = dbContext.Users.FirstOrDefault(u => u.Email == newUser.Email);
                if (existingUser != null)
                {
                    ModelState.AddModelError("Email", "Email is already in User!");
                    return View("Index");
                }
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                string hashedPw = hasher.HashPassword(newUser, newUser.Password);
                newUser.Password = hashedPw;
                dbContext.Users.Add(newUser);
                dbContext.SaveChanges();
                UserSession = newUser.UserId;
                return RedirectToAction("Success");
            }
            return View("Index");
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("userLogin")]
        public IActionResult userLogin(LoginUser currUser)
        {
            if (ModelState.IsValid)
            {
                User existingUser = dbContext.Users.FirstOrDefault(u => u.Email == currUser.Email);
                if (existingUser == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }
                else
                {
                    PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                    var result = hasher.VerifyHashedPassword(currUser, existingUser.Password, currUser.Password);
                    if (result == 0)
                    {
                        ModelState.AddModelError("Email", "Invalid Email/Password");
                        return View("Login");
                    }
                    UserSession = existingUser.UserId;
                    return RedirectToAction("Success");
                }
            }
            return View("Login");
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            if (UserSession != null)
                return View("Success");
            return RedirectToAction("Index");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
