using DietaAPI.Models;
using DietaAPI.Repositorios;
using DietaAPI.Repositorios.Receitas;
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
    public class ReceitasController : ControllerBase
    {
        private readonly IReceitaInterface _repositorio;
        public ReceitasController(IReceitaInterface db)
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
            return Ok( await _repositorio.BuscarItem(id));
        }

        [HttpPost]
        public async Task<ActionResult> Create(Receita receitas)
        {
            return Ok( await _repositorio.Create(receitas));
        }

        [HttpPut]
        public async Task<ActionResult> Update(Receita receitas)
        {
            return Ok(await _repositorio.Update(receitas));
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {

            _repositorio.Delete(id);
            return Ok();
        }

    }

}
