using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace rest.Controllers
{
    [ApiController]
    [Route("")]
    // ["[controller]"]
    public class WeatherForecastController : ControllerBase
    {


        SqlConnection con = new SqlConnection(@"Server=(localdb)\\mssqllocaldb;Initial Catalog=go-mysql;User ID=saiashish;Password=saiashish;Integrated Security=True;Trusted_Connection=True;MultipleActiveResultSets=true");
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        // [HttpGet]
        // public IEnumerable<WeatherForecast> Get()
        // {
        //     var rng = new Random();
        //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //     {
        //         Date = DateTime.Now.AddDays(index),
        //         TemperatureC = rng.Next(-20, 55),
        //         Summary = Summaries[rng.Next(Summaries.Length)]
        //     })
        //     .ToArray();
        // }

        // [HttpGet]
        // [Route("test")]
        public string Get()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from customer",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            if(dt.Rows.Count>0){
                return JsonConvert.SerializeObject(dt);
            }else{
                return "No data found";
            }

            // return Content("hi");
        }
    }
}
