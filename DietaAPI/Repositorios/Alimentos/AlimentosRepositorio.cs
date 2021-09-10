using DietaAPI.Contexto;
using DietaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietaAPI.Repositorios
{
    public class AlimentosRepositorio : AlimentosInterface
    {

        private readonly DietaContexto  _db;
        public AlimentosRepositorio(DietaContexto db)
        {
            _db = db;
            
        }

        public Alimento BuscarItem(Alimento AlimentoId)
        {
            var Pessoa = _db.Alimento.Find(AlimentoId);

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


        public Alimento Delete(Alimento Alimentos)
        {
            _db.Alimento.Remove(Alimentos);
            _db.SaveChanges();
            return Alimentos;
        }

        public List<Alimento> ListarTodos()
        {
            var alimento = _db.Alimento.ToList();

            return alimento;
        }
    }
}
