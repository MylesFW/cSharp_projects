using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using login_and_registration.Models;
using Microsoft.AspNetCore.Identity;

namespace login_and_registration.Controllers
{
    public class HomeController : Controller
    {
    private login_and_registrationContext db;
    public HomeController(login_and_registrationContext context)
    {
        db = context;
    }

        [HttpGet("")]
        public IActionResult Index()
        {
            return RedirectToAction("RegisterPage");
        }

        [HttpGet("register")]
        public IActionResult RegisterPage()
        {
            return View();
        }

        [HttpGet("home")]
        public IActionResult HomePage()
        {
            return View();
        }

        [HttpGet("login")]
        public IActionResult LoginPage()
        {
            return View();
        }




        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if (ModelState.IsValid)
            {
                if (db.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "This Email is already in use!");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                db.Users.Add(newUser);
                db.SaveChanges();
                return RedirectToAction("HomePage");
            }
            return View("RegisterPage");
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser userSubmission)
        {
            if (ModelState.IsValid)
            {
            var userInDb = db.Users.FirstOrDefault(u => u.Email == userSubmission.Email);

            if(userInDb == null)
            {
                ModelState.AddModelError("Email", "Invalid Email/Password");
                return View("LoginPage");
            }
            var hasher = new PasswordHasher<LoginUser>();
            var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);
            if (result == 0)
                {
                    ModelState.AddModelError("Email", "This Email is already in use!");
                }
            }
            return View("HomePage");
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
