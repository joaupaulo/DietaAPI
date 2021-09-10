using DietaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietaAPI.Repositorios
{
    interface ReceitaInterface
    {
        List<Receita> ListarTodos();
        Receita BuscarItem(Receita Receitas);
        Receita Update(Receita Receitas);
        Receita Create(Receita Receitas);
        Receita Delete(Receita Receitas);

    }
}
