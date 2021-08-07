using Microsoft.AspNetCore.Mvc;


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
      public IActionResult Result(string Name, string Location, string Language, string Comment)
      {
        ViewBag.Name = Name;
        ViewBag.Location = Location;
        ViewBag.Language = Language;
        ViewBag.Comment = Comment;
        return View("Result", ViewBag);
      }
    }
}