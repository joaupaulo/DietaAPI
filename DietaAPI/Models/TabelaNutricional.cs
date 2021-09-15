using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietaAPI.Models
{
    public class TabelaNutricional
    {
        public int TabelaNutricionalId { get; set; }
        public string Energia { get; set; }
        public string Carboidrato { get; set; }
        public string Proteinas { get; set; }
        public string Gordura { get; set; }
        public string Açucares { get; set; }
        public string Calorias { get; set; }
        public string Colesterol { get; set; }
        public string Lípidios { get; set; }
        public string Calcio { get; set; }
        public string Ferro { get; set; }
        public string FibraAlimentar { get; set; }
      
    }
}
