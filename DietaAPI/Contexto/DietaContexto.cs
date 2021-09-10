using DietaAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietaAPI.Contexto
{
    public class DietaContexto : DbContext
    {


        public DietaContexto(DbContextOptions<DietaContexto> options) : base(options)
        {

        }

        public DbSet<Alimento> Alimento { get; set; }
        public DbSet<Receita> Receita { get; set; }
        public DbSet<TabelaNutricional> TabelaNutricional { get; set; }

    }
}
