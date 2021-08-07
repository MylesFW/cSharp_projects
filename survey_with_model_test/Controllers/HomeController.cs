using dojo_survey_with_model.Models;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace dojo_survey_with_model.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("")]
      public ViewResult Index()
      {
        return View();
      }

      [HttpPost("results")]
      public IActionResult Results(HogwartsStudent student)
      {
        return View(student);
      }
    }
}