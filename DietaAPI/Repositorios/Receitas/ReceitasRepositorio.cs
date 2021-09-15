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

        public Receita BuscarItem(int id)
        {
           var itemReceita = _db.Receita.Find(id);

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

        public void Delete(int  id)
        {
            var delete = _db.Receita.Where(x => x.ReceitaId == id).FirstOrDefault();
            _db.Receita.Remove(delete);
            _db.SaveChanges();


            
        }

    }
}
