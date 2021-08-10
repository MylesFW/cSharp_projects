using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            ViewBag.WomensLeagues = _context.Leagues
                .Where(i => i.Name.Contains("Womens"))
                .ToList();

            ViewBag.HockeyLeagues = _context.Leagues
            .Where(i => i.Sport.Contains("Hockey"))
            .ToList();

            ViewBag.AllNonFootballLeagues = _context.Leagues
                .Where(i => !i.Sport.Contains("Football"))
                .ToList();

            ViewBag.ConferenceLeagues = _context.Leagues
                .Where(i => i.Name.Contains("Conference"))
                .ToList();

            ViewBag.AtlanticLeagues = _context.Leagues
                .Where(i => i.Name.Contains("Atlantic"))
                .ToList();

            ViewBag.DallasTeams = _context.Teams
                .Where(i => i.Location.Contains("Dallas"))
                .ToList();

            ViewBag.RaptorsTeams = _context.Teams
                .Where(i => i.TeamName.Contains("Raptor"))
                .ToList();

            ViewBag.CityTeams = _context.Teams
                .Where(i => i.Location.Contains("City"))
                .ToList();

            ViewBag.TTeams = _context.Teams
                .Where(i => i.TeamName.Contains("T"))
                .ToList();

            ViewBag.AlphabeticalByName = _context.Teams
                .OrderBy(i => i.TeamName)
                .ToList();

            ViewBag.AlphabeticalByLocation = _context.Teams
                .OrderBy(i => i.Location)
                .ToList();

            ViewBag.UnAlphabeticalByName = _context.Teams
                .OrderByDescending(i => i.TeamName)
                .ToList();

            ViewBag.CooperLastName = _context.Players
                .Where(i => i.LastName.Contains("Cooper"))
                .ToList();

            ViewBag.JoshuaFirstName = _context.Players
                .Where(i => i.FirstName.Contains("Joshua"))
                .ToList();

            ViewBag.CooperNotJoshua = _context.Players
                .Where(i => i.LastName.Contains("Cooper"))
                .Where(b => !b.FirstName.Contains("Joshua"))
                .ToList();

            ViewBag.AlexOrWyatt = _context.Players
                .Where(i => i.FirstName == "Alexander" || i.FirstName == "Wyatt")
                .ToList();

            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}