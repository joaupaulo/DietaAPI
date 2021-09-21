using DietaAPI.Contexto;
using DietaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietaAPI.Repositorios.TabelaNutricionais
{
    public class TabelaRepositorio : ITabelaInterface
    {


        private readonly DietaContexto _db;

        public TabelaRepositorio(DietaContexto db)
        {
            _db = db;
        }

        public async Task<TabelaNutricional> Buscaitem(int id)
        {
            return await _db.TabelaNutricional.FirstOrDefaultAsync(x => x.TabelaNutricionalId == id);
        }

        public async Task<TabelaNutricional> Create(TabelaNutricional TabelaNutricionais)
        {
            _db.TabelaNutricional.Add(TabelaNutricionais);
            await _db.SaveChangesAsync();
            return TabelaNutricionais;
        }

        public void Delete(int id)
        {
            var delete = _db.TabelaNutricional.Where(x => x.TabelaNutricionalId == id).FirstOrDefault();
            _db.TabelaNutricional.Remove(delete);
            _db.SaveChanges();

        }

        public async Task<IEnumerable<TabelaNutricional>> ListarTodos()
        {
            return await _db.TabelaNutricional.ToListAsync();
        }

        public async Task<TabelaNutricional> Update(TabelaNutricional TabelaNutricionais)
        {
            _db.TabelaNutricional.Update(TabelaNutricionais);
            await _db.SaveChangesAsync();
            return TabelaNutricionais;
        }
    }
}
