using Microsoft.AspNetCore.Mvc;
using dojo_survey.Models;


namespace Home
{
    public class HomeController : Controller
    {

      [HttpGet("")]
      public ViewResult Index()
      {
        return View();
      }

      [HttpPost("results")]
      public IActionResult Result(SurveyResults answers)
      {
        return View("Result", answers);
      }
    }
}