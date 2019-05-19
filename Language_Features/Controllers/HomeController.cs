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
        // Using nameof Expressions
        public ViewResult Index()
        {
            //var products = new[] { new { Name = "Kayak", Price = 275M },
            var products = new[] { new { Name = "Kayak", Price = 275M },
                             new { Name = "Lifejacket", Price = 48.95M },
                             new { Name = "Soccer ball", Price = 19.50M },
                             new { Name = "Corner flag", Price = 34.95M }
            };

            return View(products.Select(p =>
            $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }

    }
}
