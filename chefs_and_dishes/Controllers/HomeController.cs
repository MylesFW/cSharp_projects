using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using chefs_and_dishes.Models;
using Microsoft.EntityFrameworkCore;

namespace chefs_and_dishes.Controllers
{
    public class HomeController : Controller
    {
        private chefs_and_dishesContext db;

        public HomeController(chefs_and_dishesContext context)
        {
            db = context;
        }

        [HttpGet("")]
        public IActionResult AllChefs()
        {
            List<Chef> allChefs = db.Chefs.ToList();
            return View(allChefs);
        }

        [HttpGet("/dishes")]
        public IActionResult AllDishes()
        {
            List<Chef> allChefs = db.Chefs.ToList();
            return View();
        }


        [HttpGet("/new")]
        public IActionResult AddChef()
        {
            return View();
        }

        [HttpGet("/dishes/new")]
        public IActionResult AddDish()
        {
            List<Chef> allChefs = db.Chefs.ToList();
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
        [HttpPost("/new")]
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
