using DietaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietaAPI.Repositorios.TabelaNutricionais
{
    public interface ITabelaInterface
    {
        Task<IEnumerable<TabelaNutricional>> ListarTodos();
        Task<TabelaNutricional> Buscaitem(int id);
        Task<TabelaNutricional >Update(TabelaNutricional TabelaNutricionais);
        Task<TabelaNutricional> Create(TabelaNutricional TabelaNutricionais);
        void Delete(int  id);

    }
}
