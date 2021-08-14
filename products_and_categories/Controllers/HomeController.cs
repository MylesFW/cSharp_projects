using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using products_and_categories.Models;

namespace products_and_categories.Controllers
{
    public class HomeController : Controller
    {
    private products_and_categoriesContext db;
    public HomeController(products_and_categoriesContext context)
    {
        db = context;
    }
//****************************************************************************************************

        [HttpGet("")]
        public IActionResult Index()
        {
            return RedirectToAction("Products", "Product");
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
