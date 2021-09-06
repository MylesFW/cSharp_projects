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
    public class ProductController : Controller
    {
    private products_and_categoriesContext db;
    public ProductController(products_and_categoriesContext context)
    {
        db = context;
    }
//****************************************************************************************************
        [HttpGet("products")]
        public IActionResult Products()
        {
            List<Product> AllProducts = db.Products
                .Include(prod => prod.ProductList)
                    .ThenInclude(item => item.Category)
                .ToList();
            return View(AllProducts);
        }

        [HttpGet("products/add")]

        public IActionResult AddProducts()
        {
            return RedirectToAction("Products", "Product");
        }

        [HttpPost("products/add")]
        public IActionResult AddProducts(Product newProd)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(newProd);
                db.SaveChanges();
                return RedirectToAction("Products", "Product");
            }
            return View("Products", "Product");
        }

        [HttpGet("/products/{productId}")]
        public IActionResult ProductDetails(int productId)
        {
            Product prod = db.Products
                .Include(product => product.ProductList)
                .ThenInclude(catProd => catProd.Category)
                .FirstOrDefault(p => p.ProductId == productId);
            
            if (prod == null)
            {
                return RedirectToAction("Products");
            }

            ViewBag.Product = prod;

            List<Category> allCategories = db.Categorys
                .Include(cat => cat.CategoryList)
                .ToList();
//----------------------------------

            List<Category> unrelatedCategories = new List<Category>();

            ViewBag.UnrelatedCats = db.Categorys
                .Include(cat => cat.CategoryList)
                .Where(cat => cat.CategoryList
                    .Any(catProd => catProd.ProductId == prod.ProductId) == false
                    )
                .ToList();
//----------------------------------

            List<Category> relatedCategories = new List<Category>();

            ViewBag.RelatedCats = db.Categorys
                .Include(cat => cat.CategoryList)
                .Where(cat => cat.CategoryList
                    .Any(catProd => catProd.ProductId == prod.ProductId) != false
                    )
                .ToList();

            return View("Details", prod);
        }

        [HttpPost("/products/{productId}/relate")]
        public IActionResult AddProdToCat(int productId, Association newAssociation)
        {
            newAssociation.ProductId = productId;
            db.Associations.Add(newAssociation);
            db.SaveChanges();
            return RedirectToAction("ProductDetails");
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
