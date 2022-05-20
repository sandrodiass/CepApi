using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CepApi.Models
{
    public class FreteDdd
    {
        public int Id { get; set; }
        public string Ddd { get; set; }
        public Decimal ValorDoFrete { get; set; }

    }
    
}
