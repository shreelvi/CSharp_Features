using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Language_Features.Models;

namespace Language_Features.Controllers
{
    public class HomeController : Controller
    {

        // Expressing an Action Method as a Lambda Expression 

        // Using Type Inference and Anonymous Types 
        public IActionResult Index()
        {
            var products = new[] { new { Name = "Kayak", Price = 275M },
                           new { Name = "Lifejacket", Price = 48.95M },
                           new { Name = "Soccer ball", Price = 19.50M },
                           new { Name = "Corner flag", Price = 34.95M }
            };

            return View(products.Select(p => p.Name));
            //return View(products.Select(p => p.GetType().Name)); //All the objects in product array will have same type                                                                 //Because they have same properties
        }

    }
}
