using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using chefs_and_dishes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace chefs_and_dishes.Controllers
{
    public class HomeController : Controller
    {
        private chefs_and_dishesContext db;

        public HomeController(chefs_and_dishesContext context)
        {
            db = context;
        }


        //--------------------------------------------------------------------
        [HttpGet("/dishes")]
        public IActionResult AllDishes()
        {
            List<Dish> allDishes = db.Dishes
            .Include(d => d.Creator) // able to include the ChefName in the table
            .ToList();
            return View(allDishes);
        }


        [HttpGet("/dishes/new")]
        public IActionResult AddDish()
        {
            List<Chef> allChefs = db.Chefs.ToList(); //adds the ChefName dropdown
            ViewBag.allChefs = allChefs;
            return View();
        }


        [HttpPost("/dishes/new")]
        public IActionResult AddDish(Dish newDish)
        {
            if (ModelState.IsValid)
            {
                db.Dishes.Add(newDish);
                db.SaveChanges();
                return RedirectToAction("AllDishes");
            }
            return View("AddDish");
        }

        //--------------------------------------------------------------------
        [HttpGet("")] //render the page with the list of chefs
        public IActionResult AllChefs() 
        {
            List<Chef> allChefs = db.Chefs
            .Include(chef => chef.CreatedDishes)
            .ToList();
            return View(allChefs);
        }


        [HttpGet("/new")] //render the new chef page
        public IActionResult AddChef()
        {
            return View();
        }


        [HttpPost("/new")] //add the new chef to the db and route back to AllChefs
        public IActionResult AddChef(Chef newChef)
        {
            if (ModelState.IsValid)
            {
                db.Chefs.Add(newChef);
                db.SaveChanges();
                return RedirectToAction("AllChefs");
            }
            return View("AddChef");
        }
        //--------------------------------------------------------------------


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
