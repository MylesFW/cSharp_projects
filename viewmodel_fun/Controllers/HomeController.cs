using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using survey_with_validation.Models;

namespace survey_with_validation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
        // ASSIGNMENT ----------------------------------------------------
        [HttpGet("")]
        public IActionResult Index()
        {
            IndexView_Message messageDisplay = new IndexView_Message()
            {
                SingleMessage = "Here is the home screen message!"
            };
            return View(messageDisplay);
        }


        [HttpGet("name")]
        public IActionResult Name()
        {
            IndexView_Name singleUser = new IndexView_Name()
            {
                FirstName = "Myles",
                LastName = "Williams"
            };
            return View(singleUser);
        }

        [HttpGet("names")]

        public IActionResult Names(string[] args)
        {
            IndexView_Names listOfNames = new IndexView_Names()
            {
            names = new string[]
                {
                    "Myles",
                    "Johnny",
                    "Randy",
                    "Mr. Layhe",
                    "Bubbles",
                    "Moose",
                }
            };
        return View(listOfNames);
        }

        [HttpGet("numbers")]

        public IActionResult Numbers(int[] args)
        {
            IndexView_Numbers listOfNumbers = new IndexView_Numbers()
            {
            numbers = new int[] 
                {
                    1,
                    2,
                    3,
                    4,
                    5,
                    6
                }
            };
        return View(listOfNumbers);
        }
    }
}
