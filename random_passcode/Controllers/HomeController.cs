using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using random_passcode.Models;

namespace random_passcode.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            string possibleOptions = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"; //here are the choices for the code
            var combinedOptions = new char[14]; // length of final code
            Random select = new Random(); // create the random object

            for (int i = 0; i < combinedOptions.Length; i++)
            {
                combinedOptions[i] = possibleOptions[select.Next(possibleOptions.Length)];
            }

            if (HttpContext.Session.GetInt32("counter") == null) // is there a session running? null == no
            {
                HttpContext.Session.SetInt32("counter", 0); // create a counter and set couter to 0
            }

            int counter = (int)HttpContext.Session.GetInt32("counter");  // now that that counter is in session, create an int var for it

            if (counter == 0 ) // if the counter is 0 
            {
                counter++; // counter +1
                HttpContext.Session.SetInt32("counter", counter); // set session counter to (counter +1)
            }
            else
            {
                counter++;
                HttpContext.Session.SetInt32("counter", counter);
            }

            for (int i = 0; i < combinedOptions.Length; i++)
            {
                combinedOptions[i] = possibleOptions[select.Next(possibleOptions.Length)];
            }

            var compiledPasscode = new String(combinedOptions); // this converts the code to a string
            CodeGenerator passcode = new CodeGenerator() // passcode = new Model Class
            {
                Passcode = compiledPasscode, // sets the Passcode in the model 
                Counter = (int)counter // sets the Counter in the model
            };
            return View(passcode); // return the password
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
