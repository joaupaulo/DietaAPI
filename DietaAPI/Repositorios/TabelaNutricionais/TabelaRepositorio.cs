using DietaAPI.Contexto;
using DietaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietaAPI.Repositorios.TabelaNutricionais
{
    public class TabelaRepositorio : TabelaInterface
    {


        private readonly DietaContexto _db;

        public TabelaRepositorio(DietaContexto db)
        {
            _db = db;
        }
   
        public List<TabelaNutricional> ListarTodos () {



            return _db.TabelaNutricional.ToList();

        }
      
        public TabelaNutricional Buscaitem(int id)
        {
            var buscaitem = _db.TabelaNutricional.Where(x => x.TabelaNutricionalId == id).FirstOrDefault();

            return buscaitem;
        }

        public TabelaNutricional Create(TabelaNutricional TabelaNutricionais)
        {
          _db.TabelaNutricional.Add(TabelaNutricionais);
            _db.SaveChanges();

            return TabelaNutricionais;
        }

        public void Delete(int id)
        {
            var delete = _db.TabelaNutricional.Where(x => x.TabelaNutricionalId == id).FirstOrDefault();
             
        }

        public TabelaNutricional Update(TabelaNutricional TabelaNutricionais)
        {
            _db.TabelaNutricional.Update(TabelaNutricionais);
            _db.SaveChanges();

            return TabelaNutricionais;
        }
    }
}
