using DietaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietaAPI.Repositorios
{
    public interface IReceitaInterface
    {
       Task<IEnumerable<Receita>> ListarTodos();
       Task<Receita> BuscarItem(int id);
       Task<Receita> Update(Receita Receitas);
       Task<Receita> Create(Receita Receitas);
        void Delete(int id);

    }
}
