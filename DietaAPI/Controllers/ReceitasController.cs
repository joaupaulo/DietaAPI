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
        public ActionResult BuscarTodostens()
        {
            return Ok(_repositorio.ListarTodos());
        }
        [HttpGet("{id}")]
        public ActionResult BuscarItem(int id)
        {
            return Ok(_repositorio.BuscarItem(id));
        }

        [HttpPost]
        public ActionResult Create(Receita receitas)
        {
            return Ok(_repositorio.Create(receitas));
        }

        [HttpPut]
        public ActionResult Update(Receita receitas)
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
