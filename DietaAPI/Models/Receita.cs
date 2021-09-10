using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietaAPI.Models
{
    public class Receita
    {
        public int ReceitaId { get; set; }
        public string Nome { get; set; }
        public string Ingredientes { get; set; }
        public string Preparatorio { get; set; }
        public Alimento Alimento { get; set; }
        public int AlimentoId { get; set; }
        public TabelaNutricional TabelaNutricional { get; set; }
        public int TabelaNutricionalId { get; set; }

    }
}
