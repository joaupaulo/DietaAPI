using DietaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietaAPI.Repositorios.TabelaNutricionais
{
    interface TabelaInterface
    {
        List<TabelaNutricional> ListarTodos { get; set; }
        TabelaNutricional Buscaitem(TabelaNutricional TabelaNutricionais);
        TabelaNutricional Update(TabelaNutricional TabelaNutricionais);
        TabelaNutricional Create(TabelaNutricional TabelaNutricionais);
        TabelaNutricional Delete(TabelaNutricional TabelaNutricionais);

    }
}
