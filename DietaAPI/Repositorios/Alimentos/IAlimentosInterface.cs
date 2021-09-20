using DietaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietaAPI.Repositorios
{
   public  interface IAlimentosInterface
    {
        Task<IEnumerable<Alimento>> ListarTodos();
        Task<Alimento> BuscarItem(int Id);
        Task<Alimento> Create(Alimento Alimentos);
        Task<Alimento> Update(Alimento Alimentos);

        void Delete(int Id);

    }
}
