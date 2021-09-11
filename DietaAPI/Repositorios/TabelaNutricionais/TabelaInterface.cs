using DietaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietaAPI.Repositorios.TabelaNutricionais
{
    interface TabelaInterface
    {
        List<TabelaNutricional> ListarTodos();
        TabelaNutricional Buscaitem(int id);
        TabelaNutricional Update(TabelaNutricional TabelaNutricionais);
        TabelaNutricional Create(TabelaNutricional TabelaNutricionais);
        void Delete(int  id);

    }
}
