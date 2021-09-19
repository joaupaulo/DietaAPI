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
        public ActionResult BuscarTodositens()
        {
            return Ok(_repositorio.ListarTodos());
        }

        [HttpGet("{id}")]
        public ActionResult BuscarItem(int id)
        {
            return Ok(_repositorio.BuscarItem(id));
        }

        [HttpPost]
        public ActionResult Create(Alimento alimentos)
        {
            return Ok(_repositorio.Create(alimentos));
        }

        [HttpPut]
        public ActionResult Update(Alimento alimentos)
        {
            return Ok(_repositorio.Update(alimentos));
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {

            _repositorio.Delete(id);
            return Ok();
        }

    }
}
