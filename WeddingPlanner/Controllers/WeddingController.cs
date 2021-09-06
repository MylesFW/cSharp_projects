using System;
using System.Collections.Generic;
using System.Linq;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Controllers
{
    public class WeddingController : Controller
    {
        private WeddingPlanContext db;

        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }

        private bool isLoggedIn
        {
            get
            {
                return uid != null;
            }
        }

        public WeddingController(WeddingPlanContext context)
        {
            db = context;
        }

        // 1. handles GET request to DISPLAY the form used to create a new Post
        [HttpGet("/weddings/new")]
        public IActionResult New()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            return View("New");
        }

        // 2. handles POST request form submission to CREATE a new Post model instance
        [HttpPost("/weddings/create")]
        public IActionResult Create(Wedding newWedding)
        {
            // Every time a form is submitted, check the validations.
            if (ModelState.IsValid == false)
            {
                // Go back to the form so error messages are displayed.
                return View("New");
            }

            if(newWedding.Date < DateTime.Now)
            {
              ModelState.AddModelError("Date","must be a future Date.");
              return View("New");
            }

            newWedding.UserId = (int)uid; // Relate the author to the post.

            // The above return did not happen so ModelState IS valid.
            db.Weddings.Add(newWedding);
            // db doesn't update until we run save changes
            // after SaveChanges, our newPost object now has it's PostId updated from db auto generated id
            db.SaveChanges();
            return RedirectToAction("All");
        }

        [HttpGet("/weddings")]
        public IActionResult All()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            List<Wedding> allWeddings = db.Weddings
                // Select what navigation properties from a Post you want to be included (JOIN).
                .Include(post => post.CreatedBy) // hover over the param to see it's data type
                .Include(post => post.RSVPs)
                .ToList();
            return View("All", allWeddings);

            /* 
            The db.Posts and the .Include did this:
            SELECT * FROM posts AS p
            JOIN users AS u ON u.UserId = p.UserId
            */
        }

        [HttpGet("/weddings/{weddingId}")]
        public IActionResult Details(int weddingId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            Wedding wedding = db.Weddings
                .Include(post => post.CreatedBy)
                .Include(post => post.RSVPs)
                // Include something from the last thing that was included.
                // Include the User from the likes (hover over like param to see data type)
                .ThenInclude(rsvp => rsvp.User)
                .FirstOrDefault(w => w.WeddingId == weddingId);

            if (wedding == null)
            {
                return RedirectToAction("All");
            }

            return View("Details", wedding);
        }

        [HttpPost("/weddings/{weddingId}/delete")]
        public IActionResult Delete(int weddingId)
        {
            Wedding wedding = db.Weddings.FirstOrDefault(w => w.WeddingId == weddingId);

            if (wedding == null)
            {
              return RedirectToAction("All");
            }

            db.Weddings.Remove(wedding);
            db.SaveChanges();
            return RedirectToAction("All");
        }

        [HttpGet("/weddings/{weddingId}/edit")]
        public IActionResult Edit(int weddingId)
        {
            Wedding wedding = db.Weddings.FirstOrDefault(w => w.WeddingId == weddingId);

            // The edit button will be hidden if you are not the author,
            // but the user could still type the URL in manually, so
            // prevent them from editing if they are not the author.
            if (wedding == null || wedding.UserId != uid)
            {
                return RedirectToAction("All");
            }

            return View("Edit", wedding);
        }

        [HttpPost("/weddings/{weddingId}/update")]
        public IActionResult Update(int weddingId, Wedding editedWedding)
        {
            if (ModelState.IsValid == false)
            {
                editedWedding.WeddingId = weddingId;
                // Send back to the page with the current form edited data to
                // display errors.
                return View("Edit", editedWedding);
            }

            Wedding dbWedding = db.Weddings.FirstOrDefault(w => w.WeddingId == weddingId);

            if (dbWedding == null)
            {
                return RedirectToAction("All");
            }

            dbWedding.WedderOne = editedWedding.WedderOne;
            dbWedding.WedderTwo = editedWedding.WedderTwo;
            dbWedding.Address = editedWedding.Address;
            dbWedding.UpdatedAt = DateTime.Now;

            db.Weddings.Update(dbWedding);
            db.SaveChanges();

            /* 
            When redirecting to action that has params, you need to pass in a
            dict with keys that match param names and the value of the keys are
            the values for the params.
            */
            return RedirectToAction("Details", new { weddingId = weddingId });
        }

        [HttpPost("/weddings/{weddingId}/rsvp")]
        public IActionResult RSVP(int weddingId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            UserWeddingRSVP existingRSVP = db.RSVPs
                .FirstOrDefault(rsvp => rsvp.UserId == (int)uid && rsvp.WeddingId == weddingId);

            if (existingRSVP == null)
            {
                UserWeddingRSVP rsvp = new UserWeddingRSVP()
                {
                    WeddingId = weddingId,
                    UserId = (int)uid
                };

                db.RSVPs.Add(rsvp);
            }
            else
            {
                db.RSVPs.Remove(existingRSVP);
            }


            db.SaveChanges();
            return RedirectToAction("All");
        }
    }
}