using DietaAPI.Contexto;
using DietaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietaAPI.Repositorios.Receitas
{
    public class ReceitasRepositorio : ReceitaInterface
    {
        private readonly DietaContexto _db;

        public ReceitasRepositorio(DietaContexto db)
        {
            _db = db;
        }

      public List<Receita> ListarTodos()
        {

            return _db.Receita.ToList();
        }

        public Receita BuscarItem(Receita receitasid)
        {
           var itemReceita = _db.Receita.Find(receitasid);

            return itemReceita;
        }


        public Receita Create(Receita receitas)
        {
            _db.Receita.Add(receitas);
            _db.SaveChanges();


            return receitas;
        }

        public Receita Update(Receita receitas)
        {
            _db.Receita.Update(receitas);
            _db.SaveChanges();


            return receitas;
        }

        public Receita Delete(Receita receitas)
        {
            _db.Receita.Remove(receitas);
            _db.SaveChanges();


            return receitas;
        }

    }
}
