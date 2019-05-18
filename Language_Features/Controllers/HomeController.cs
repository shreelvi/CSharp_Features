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
            //string[] names = new string[3];
            //names[0] = "Bob";
            //names[1] = "Joe";
            //names[2] = "Alice";
            //return View("Index", names);

            //Using collection initializer to create collection in one step
            return View("Index", new string[] { "Bob", "Joe", "Alice" });
        }


    }
}
