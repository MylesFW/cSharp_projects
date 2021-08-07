﻿using System;
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
        // public IActionResult Index()
        // {
        //     IndexView singleUser = new IndexView()
        //     {
        //         FirstName = "John",
        //         LastName = "Williams"
        //     };
        //     return View(singleUser);
        // }

        public IActionResult Index(string[] args)
        {
            IndexNameList listOfNames = new IndexNameList()
            {
            names = new string[] 
                {
                    "Myles",
                    "Jack",
                    "Benny",
                    "Moose"
                }
            };
        return View(listOfNames);
        }
    }
}
