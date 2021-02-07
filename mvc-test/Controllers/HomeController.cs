using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_test.Models;

namespace mvc_test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            // return View();
            return Json("data");
        }

        public ActionResult Edit(int? id, string x)
        {
            if (!id.HasValue)
                id = 1;
            if (String.IsNullOrWhiteSpace(x))
                x = "a";
            return Content(String.Format("id={0} & x={1}",id,x));
        }

        // int? id,string x


        // Content File Redirect RedirectToAction HttpNotFound
        // View PartialView 
        // new EmptyResult();
        // RedirectToAction("Index","Home",new {page=1,sortBy="name"})

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
