using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using mvc_test.Models;

namespace mvc_test.Controllers
{
    public class MovieController : Controller
    {

        //  constraints min,max,minlength,maxlength,int,float,guid

        [Route("movies/released/{year}/{month:length(1):range(1,12)}")]
        public IActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        [Route("movies/random")]

        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Sai" };

            // ViewData["Movie"] = movie;
            // var viewResult = new ViewResult();
            // viewResult.ViewData.Model
            // ViewBag.Movie = movie;

            var customers = new List<Customer>{
                new Customer{Name="Sai"},
                new Customer{Name="Ashish"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

    }
}