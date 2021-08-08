using Microsoft.AspNetCore.Mvc;
using dojo_survey.Models;


namespace Home
{
    public class HomeController : Controller
    {


      [HttpGet("")]
      public IActionResult HomePage()
      {
        return View("HomePage");
      }


      [HttpPost("user")]
      public IActionResult CreateUser(User newUser)
      {
        if (ModelState.IsValid)
        {
          return View("NewUser");
        }
        else
        {
          return View("HomePage");
        }
      }
    }

}