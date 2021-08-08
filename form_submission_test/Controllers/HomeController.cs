using Microsoft.AspNetCore.Mvc;
using dojo_survey.Models;


namespace Home
{
    public class HomeController : Controller
    {

      [HttpGet("")]
      public IActionResult Index()
      {
        return View();
      }


      [HttpPost("create")]
      public IActionResult Create(User userInfo)
      {
        if(ModelState.IsValid)
        {
          return View("Result");
        }
        else
        {
          return View("Index");
        }
      }
    }
}