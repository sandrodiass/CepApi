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
        private DbNameContex _contex;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, DbNameContex contex)
        {
            _logger = logger;
            _contex = contex;
        }



        [HttpGet]
        public endereco Get(string cep )
        {

            RestClient client = new RestClient( string.Format ( $"https://viacep.com.br/ws/{cep}/json/"));
            RestRequest request = new RestRequest("", Method.Get);
            var Response = client.ExecuteGetAsync<endereco>(request);

            endereco endereco = new endereco();

            

            endereco = Response.Result.Data;

            //endereco.Ddd
            // f => 

            var Freteeddd = _contex.freteDdds.Where(f => f.Ddd == endereco.Ddd).FirstOrDefault();
            
            endereco.Frete = Freteeddd.ValorDoFrete;
            return endereco ;
            





        }
       
    }
}