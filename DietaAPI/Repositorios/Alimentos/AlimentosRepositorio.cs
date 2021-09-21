using DietaAPI.Contexto;
using DietaAPI.Models;
using Microsoft.EntityFrameworkCore;
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

     
      public async Task<IEnumerable<Alimento>> ListarTodos()
        {
            return await _db.Alimento.ToListAsync();
        }

      public async Task<Alimento> BuscarItem(int Id)
        {

            return await _db.Alimento.FirstOrDefaultAsync(x => x.AlimentoId == Id);

        }

      public async Task<Alimento> Create(Alimento Alimentos)
        {

            _db.Alimento.Add(Alimentos);
            await _db.SaveChangesAsync();
            return Alimentos;


        }

      public async Task<Alimento> Update(Alimento Alimentos)
        {
            _db.Alimento.Update(Alimentos);
            await _db.SaveChangesAsync();
            return Alimentos;
        }

        public void Delete(int Id)
        {
            var delete = _db.Receita.Where(x => x.ReceitaId == Id).FirstOrDefault();
            _db.Receita.Remove(delete);
            _db.SaveChanges();
        }
    }
}
