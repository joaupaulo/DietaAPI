using DietaAPI.Contexto;
using DietaAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietaAPI.Repositorios.Receitas
{
    public class ReceitasRepositorio : IReceitaInterface
    {
        private readonly DietaContexto _db;

        public ReceitasRepositorio(DietaContexto db)
        {
            _db = db;
        }

        public async Task<Receita> BuscarItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Receita> Create(Receita Receitas)
        {
            _db.Alimento.Add(Alimentos);
            await _db.SaveChangesAsync();
            return Alimentos;
        }

        public void Delete(int  id)
        {
            var delete = _db.Receita.Where(x => x.ReceitaId == id).FirstOrDefault();
            _db.Receita.Remove(delete);
            _db.SaveChanges();


            
        }

        public async Task<IEnumerable<Receita>> ListarTodos()
        {
            return await _db.Receita.ToListAsync();
        }

        public async Task<Receita> Update(Receita Receitas)
        {
            _db.Receita.Update(Receitas);
            await _db.SaveChangesAsync();
            return Receitas;
        }
    }
}
