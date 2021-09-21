using DietaAPI.Models;
using DietaAPI.Repositorios.Receitas;
using DietaAPI.Repositorios.TabelaNutricionais;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TabelasController : ControllerBase
    {
        private readonly ITabelaInterface _repositorio;
        public TabelasController(ITabelaInterface db)
        {
            _repositorio = db;


        }

        [HttpGet]
        public async Task<ActionResult> BuscarTodostens()
        {
            return Ok( await _repositorio.ListarTodos());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> BuscarItem(int id)
        {
            return Ok( await _repositorio.Buscaitem(id));
        }

        [HttpPost]
        public   async Task<ActionResult> Create(TabelaNutricional tabelas)
        {
            return Ok( await _repositorio.Create(tabelas));
        }

        [HttpPut]
        public async  Task<ActionResult> Update(TabelaNutricional receitas)
        {
            return Ok( await _repositorio.Update(receitas));
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {

            _repositorio.Delete(id);
            return Ok();
        }


    }
}
