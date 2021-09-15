using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietaAPI.Models
{
    public class Alimento
    {
        public int AlimentoId { get; set; }
        public int Nome { get; set; }
        public string Origem { get; set; }
        public int ReceitaId { get; set; }
        public Receita Receita { get; set; }
        public int TabelaNutricionalId { get; set; }
        public TabelaNutricional TabelaNutricional { get; set; }



    }
}
