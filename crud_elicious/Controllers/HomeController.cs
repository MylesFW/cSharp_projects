using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using crud_elicious.Models;
using Microsoft.EntityFrameworkCore;
using crud_elicious.Migrations;

namespace crud_elicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
    
        public HomeController(MyContext context)
        {
            _context = context;
        }
    
        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dish> AllDishes = _context.Dish.ToList();
            return View(AllDishes);
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost("new")]
        public IActionResult New(Dish newDish)
        {
            if (ModelState.IsValid)
            {
                _context.Dish.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index"); // RedirectToAction calls the controller function
            }
            else
            {
                return View("New");
            }
        }

        [HttpGet("{DishId}")]
        public IActionResult ViewDish(int DishId)
        {
            Dish oneDish = _context.Dish.FirstOrDefault(id=>id.DishId == DishId);

            return View(oneDish);
        }

        [HttpGet("delete/{DishId}")] // delete should be a form as a Post to prevent preloading the delete
        public IActionResult Delete(int DishId)
        {
            Dish RetrievedDish = _context.Dish
            .SingleOrDefault(delete => delete.DishId == DishId);
            _context.Dish.Remove(RetrievedDish);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("/edit/{dishId}")]
        public IActionResult EditDish(int dishId)
        {
            Dish updatedDish = _context.Dish
            .FirstOrDefault(dish => dish.DishId == dishId);

        return View("EditDish", updatedDish);
        }

        [HttpPost("/edit")]
        public IActionResult Edit(int dishId, Dish updatedDish)
        {
            Dish dbDish = _context.Dish.FirstOrDefault(info => info.DishId == dishId);

            if (dbDish != null)
            {
                dbDish.DishId = dbDish.DishId;
                dbDish.Name = updatedDish.Name;
                dbDish.Chef = updatedDish.Chef;
                dbDish.Tastiness = updatedDish.Tastiness;
                dbDish.Calories = updatedDish.Calories;
                dbDish.Description = updatedDish.Description;
                dbDish.UpdatedAt = DateTime.Now;
                
            _context.Dish.Update(dbDish);
            _context.SaveChanges();
            return RedirectToAction("Index", dbDish);
            }
            return View("EditDish");
        }













        private readonly ILogger<HomeController> _logger;

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
