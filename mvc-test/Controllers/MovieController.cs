using System;
using Microsoft.AspNetCore.Mvc;

namespace mvc_test.Controllers{
    public class MovieController : Controller{
        
        //  constraints min,max,minlength,maxlength,int,float,guid

        [Route("movies/released/{year}/{month:length(1):range(1,12)}")]    
        public IActionResult ByReleaseDate(int year,int month){
            return Content(year+"/"+month);
        }

    }
}