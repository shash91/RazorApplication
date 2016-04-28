using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazorApplication.Models;

namespace RazorApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Product myproduct = new Product
        {
            ProductId = 1,
            Name = "Kayak",
            Description = "A boat ",
            Category = "Watersports",
            price = 275M

        };
        public ActionResult Index()
        {
            return View(myproduct);
        }
        public ActionResult NameAndPrice()
        {
            return View(myproduct);
        }
        public ActionResult DemoExpression()
        {
            ViewBag.ProductCount = 1;
            ViewBag.ExpressShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;
            return View(myproduct);
        }

        public ActionResult DemoArray()
        {
            Product[] array =
            {
                new Product {Name="kayak",price=275M },
                new Product {Name="LifeJacket",price=48.95M },
                new Product {Name="Soccer Ball",price=19.50M },
                new Product {Name="Corner flag",price=34.95M }
            };
            return View(array);
        }
    }
}