using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.AllDishes = dbContext.Dishes;
            return View();
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Dish newDish)
        {
            if (ModelState.IsValid)
            {
                dbContext.Dishes.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("new");
        }

        [HttpGet("{dishId}")]
        public IActionResult Show(int dishId)
        {   
            Dish thisDish = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);
            return View(thisDish);
        }

        [HttpGet("edit/{dishId}")]
        public IActionResult Edit(int dishId)
        {
            Dish thisDish = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);
            return View(thisDish);
        }

        [HttpPost("update/{dishId}")]
        public IActionResult Update(Dish thisDish, int dishId)
        {
            Dish toUpdate = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);
            if(ModelState.IsValid)
            {
                toUpdate.Chef = thisDish.Chef;
                toUpdate.Name = thisDish.Name;
                toUpdate.Calories = thisDish.Calories;
                toUpdate.Tastiness = thisDish.Tastiness;
                toUpdate.Description = thisDish.Description;
                toUpdate.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Edit");
        }

        [HttpPost("delete/{dishId}")]
        public IActionResult Delete(int dishId)
        {
            Dish toDelete = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);
            dbContext.Dishes.Remove(toDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
