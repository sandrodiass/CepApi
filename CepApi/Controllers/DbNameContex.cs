using CepApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CepApi.Controllers
{
    public class DbNameContex:DbContext
    {
        public DbNameContex(DbContextOptions<DbNameContex> options) : base (options)
        {
                
        }
        public DbSet<FreteDdd> freteDdds { get; set; }
    }
}
