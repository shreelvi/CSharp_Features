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
            List<string> results = new List<string>();
            foreach (Product p in Product.GetProducts())
            {
                // Combining the Conditional and Coalescing Operators.
                // The null conditional operator prevents a NullReferenceException when navigating
                // through the object properties, and the null coalescing operator 
                // ensures that I don’t include null values in
                // the results displayed in the browser

                string name = p?.Name ?? "<No Name>";
                decimal? price = p?.Price ?? 0;
                string relatedName = p?.Related?.Name ?? "<None>";

                results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}",
                name, price, relatedName));

            }
            return View(results);
        }


    }
}
