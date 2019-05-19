using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Language_Features.Models;

namespace Language_Features.Controllers
{
    // Using the null conditional operator
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Object initializer

            //Using myextensionmethod applied to the interface
            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
            Product[] productArray = { new Product {Name = "Kayak", Price = 275M},
                                       new Product {Name = "Lifejacket", Price = 48.95M},
                                       new Product {Name = "Soccer ball", Price = 19.50M},
                                       new Product {Name = "Corner flag", Price = 34.95M}
            };

            decimal priceFilterTotal = productArray.Filter(p => (p?.Price ?? 0) >= 20).TotalPrices();
            decimal nameFilterTotal = productArray.Filter(p => p?.Name?[0] == 'S').TotalPrices();

            return View("Index", new string[] {
                $"Price Total: {priceFilterTotal:C2}",
                $"Name Total: {nameFilterTotal:C2}" });
       
        }


    }
}
