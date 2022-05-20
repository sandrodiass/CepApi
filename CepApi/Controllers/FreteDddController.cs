using CepApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreteDddController : ControllerBase
    {
        private DbNameContex _contex;
        public FreteDddController(DbNameContex contex) 
        {
            _contex = contex;
        }
        [HttpGet]
        public IActionResult Get() 
        {
            var ddds = _contex.freteDdds.ToList();
            return Ok(ddds);
        
        }
        [HttpPost]

        public IActionResult Add(FreteDdd freteDdd ) 
       {
            _contex.freteDdds.Add(freteDdd);
            _contex.SaveChanges();
            return Ok("adicionado com sucesso ");

       }
    }
}
