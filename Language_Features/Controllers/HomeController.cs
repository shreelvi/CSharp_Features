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
                                       new Product {Name = "Lifejacket", Price = 48.95M}
            };
            decimal cartTotal = cart.TotalPrices();
            decimal arrayTotal = productArray.TotalPrices();

            return View("Index", new string[] { $"Cart Total: {cartTotal:C2}",
                         $"Array Total: {arrayTotal:C2}" });
        }


    }
}
