using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using products_and_categories.Models;

namespace products_and_categories.Controllers
{
    public class CategoryController : Controller
    {
    private products_and_categoriesContext db;
    public CategoryController(products_and_categoriesContext context)
    {
        db = context;
    }
//****************************************************************************************************
        [HttpGet("/categories")]
        public IActionResult Categories()
        {
            List<Category> AllCategories = db.Categorys
                .Include(cat => cat.CategoryList)
                    .ThenInclude(item => item.Category)
                .ToList();
            return View(AllCategories);
        }

        [HttpGet("/categories/add")]

        public IActionResult AddCategories()
        {
            return RedirectToAction("Categories", "Category");
        }

        [HttpPost("/categories/add")]
        public IActionResult AddCategories(Category newCat)
        {
            if (ModelState.IsValid)
            {
                db.Categorys.Add(newCat);
                db.SaveChanges();
                return RedirectToAction("Categories", "Category");
            }
            return View("Categories");
        }


        
        [HttpGet("/categories/{categoryId}")]
        public IActionResult DetailsPage(int categoryId)
        {
            Category cat = db.Categorys
                .Include(cat => cat.CategoryList)
                .ThenInclude(prodCat => prodCat.Category)
                .FirstOrDefault(c => c.CategoryId == categoryId);

            ViewBag.Category = cat;

            List<Product> allProducts = db.Products
                .Include(prod => prod.ProductList)
                .ToList();

            List<Product> unrelatedProducts = new List<Product>();

            ViewBag.UnrelatedProds = db.Products
                .Include(prod => prod.ProductList)
                .Where(prod => prod.ProductList
                    .Any(prodCat => prodCat.CategoryId == cat.CategoryId) == false
                    )
                .ToList();

            List<Category> relatedCategories = new List<Category>();

            ViewBag.RelatedProds = db.Products
                .Include(prod => prod.ProductList)
                .Where(prod => prod.ProductList
                    .Any(prodCat => prodCat.CategoryId == cat.CategoryId) != false
                    )
                .ToList();

            return View("Details", cat);
        }

        [HttpPost("/category/{categoryId}/relate")]
        public IActionResult AddCatToProd(int categoryId, Association newAssociation)
        {
            newAssociation.CategoryId = categoryId;
            db.Associations.Add(newAssociation);
            db.SaveChanges();
            return RedirectToAction("DetailsPage");
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
