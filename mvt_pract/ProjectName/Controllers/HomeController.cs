using Microsoft.AspNetCore.Mvc;

namespace Hello
{
    public class HelloController : Controller
    {

      [HttpGet("")]
      public ViewResult Index()
      {
        // this will look for a matching method name - Views/Home/Index.cshtml
        // if it can't find the file, it will look for it in the Shared folder
        return View(); // View("Index"); <- providing the name is optional if the names differ
      }


      //localhost:5000/hello
      [HttpGet("contact")]
      public ViewResult Contact()
      {
        return View();
      }


      //localhost:5000/users/???
      [HttpGet("project")]
      public ViewResult Projects() //must have the same name as the url
      {
        return View();
      }

    }
}