using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            var Listadeendereco = new List<endereco>
            {
               new endereco{Cep = "23560863" ,Bairro = "Santacruz", Estado = "Rj", Logradouro = "GUNADU2", TipodeLogradouro = "Rua" },
               new endereco{Cep = "23658485" ,Bairro = "Caompo Grande", Estado = "Rj", Logradouro = "Rio da prata", TipodeLogradouro = "Rua" },
               new endereco{Cep = "54748455" ,Bairro = "sepetiba", Estado = "Rj", Logradouro = "estrada da caixa ", TipodeLogradouro = "vloco" },
               new endereco{Cep = "23560862" ,Bairro = "Santacruz", Estado = "Rj", Logradouro = "GUNADU2", TipodeLogradouro = "Rua" },
               new endereco{Cep = "23560863" ,Bairro = "tatuap", Estado = "SP", Logradouro = "Beira Rio", TipodeLogradouro = "Rua" }
             

            };
                                                      // execulta o primeiro que ver na lista se não existir não retorna nada  
            endereco enderecos = Listadeendereco.Where(x => x.Cep == cep).FirstOrDefault();


                return (enderecos);
         
            
            

                
            
                


        }
        
    }
}