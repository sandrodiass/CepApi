using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Json;
namespace CepApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;

        }



        [HttpGet]
        public endereco Get(string cep)
        {

            RestClient client = new RestClient( string.Format ( $"https://viacep.com.br/ws/{cep}/json/"));
            RestRequest request = new RestRequest("", Method.Get);
            var Response = client.ExecuteGetAsync(request);




            return ;






        }
       
    }
}