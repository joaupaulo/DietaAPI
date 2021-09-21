using DietaAPI.Contexto;
using DietaAPI.Models;
using DietaAPI.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DietaAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AlimentosController : ControllerBase
    {

        private readonly IAlimentosInterface _repositorio;
        public AlimentosController(IAlimentosInterface db)
        {
            _repositorio = db;


        }


        
        [HttpGet]
        public async  Task<ActionResult> BuscarTodositens()
        {
            return Ok(await _repositorio.ListarTodos());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> BuscarItem(int id)
        {
            return Ok(await _repositorio.BuscarItem(id));
        }

        [HttpPost]
        public async Task<ActionResult> Create(Alimento alimentos)
        {
            return Ok( await _repositorio.Create(alimentos));
        }

        [HttpPut]
        public async Task<ActionResult> Update(Alimento alimentos)
        {
            return Ok(await _repositorio.Update(alimentos));
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {

            _repositorio.Delete(id);
            return Ok();
        }

    }
}
