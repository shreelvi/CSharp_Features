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

        //Defining an Asynchronous Action Methods in the HomeController
        public async Task<ViewResult> Index()
        {
            //var products = new[] { new { Name = "Kayak", Price = 275M },
            long? length = await MyAsyncMethods.GetPageLength();
            return View(new string[] { $"Length: {length}" });


        }

    }
}
