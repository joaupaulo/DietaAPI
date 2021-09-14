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
        private readonly TabelaRepositorio _repositorio;
        public TabelasController(TabelaRepositorio db)
        {
            _repositorio = db;


        }

        [HttpGet]
        public ActionResult BuscarTodostens()
        {
            return Ok(_repositorio.ListarTodos());
        }
        [HttpGet("{id}")]
        public ActionResult BuscarItem(int id)
        {
            return Ok(_repositorio.Buscaitem(id));
        }

        [HttpPost]
        public ActionResult Create(TabelaNutricional tabelas)
        {
            return Ok(_repositorio.Create(tabelas));
        }

        [HttpPut]
        public ActionResult Update(TabelaNutricional receitas)
        {
            return Ok(_repositorio.Update(receitas));
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {

            _repositorio.Delete(id);
            return Ok();
        }


    }
}
