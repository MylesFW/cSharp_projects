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


      [HttpGet("contact")]
      public ViewResult Contact()
      {
        return View();
      }


      [HttpGet("project")]
      public ViewResult Projects() //must have the same name as the url
      {
        return View();
      }

    }
}