using DietaAPI.Contexto;
using DietaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietaAPI.Repositorios
{
    public class AlimentosRepositorio : IAlimentosInterface
    {

        private readonly DietaContexto  _db;
        public AlimentosRepositorio(DietaContexto db)
        {
            _db = db;
            
        }

        public Alimento BuscarItem(int id)
        {
            var Pessoa = _db.Alimento.Find(id);

            return Pessoa;
           
            
        }

        public Alimento Create(Alimento Alimentos)
        {
            _db.Alimento.Add(Alimentos);
            _db.SaveChanges();
            return Alimentos;
        }

        public Alimento Update(Alimento Alimentos)
        {
            _db.Alimento.Update(Alimentos);
            _db.SaveChanges();
            return Alimentos;
        }


        public void Delete(int Id)
        {
          var delete = _db.Alimento.Where(x => x.AlimentoId == Id).FirstOrDefault();


            _db.Alimento.Remove(delete);
            _db.SaveChanges();
            
        }

        public List<Alimento> ListarTodos()
        {
            var alimento = _db.Alimento.ToList();

            return alimento;
        }
    }
}
