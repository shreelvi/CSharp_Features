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
                string name = p?.Name;
                decimal? price = p?.Price;

                //Chaining the null conditional operator
                string relatedName = p?.Related?.Name;
                results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}",
                name, price, relatedName));

            }
            return View(results);
        }


    }
}
