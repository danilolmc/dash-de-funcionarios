using System.Collections.Generic;
using System;
using System.Linq;
using desafio_mvc.Data;
using desafio_mvc.DTO;
using desafio_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace desafio_mvc.Controllers
{
    [Authorize(Policy = "AccessAdmin")]
    public class TecnologiaController : Controller
    {
        private readonly ApplicationDbContext database;

        public TecnologiaController(ApplicationDbContext database) 
        {
            this.database = database;
        }

        [Route("wa/tecnologias")]
        public IActionResult Tecnologias()
        {
            var tecnologias = database.Tecnologias.ToList();

            return View(tecnologias);
        }

        [Route("wa/tecnologias/cadastrar")]
        public IActionResult Cadastrar()
        {

            return View();
        }

        [Route("wa/tecnologias/cadastrar/salvaralteracoes")]
        [HttpPost]
        public IActionResult SalvarTecnologia(TecnologiaDTO tecnologiaTemporaria)
        {

            if (ModelState.IsValid)
            {

                Tecnologia tech = new Tecnologia();

                tech.Nome = tecnologiaTemporaria.Nome;

                database.Tecnologias.Add(tech);
                database.SaveChanges();

                return Content("1");
            }
            else
            {
                return Content("0");
            }
        }


        [Route("wa/tecnologia/editar/{Id}")]
        public IActionResult Editar(int id)
        {

            var tecnologia = database.Tecnologias.First(tech => tech.Id == id);

            TecnologiaDTO techEditar = new TecnologiaDTO();

            techEditar.Id = tecnologia.Id;
            techEditar.Nome = tecnologia.Nome;

            return View(techEditar);

        }

        [Route("wa/tecnologias/editar/editartecnologia")]
        [HttpPost]
        public IActionResult EditarTecnologia(TecnologiaDTO techTemporaria)
        {

            if (ModelState.IsValid)
            {


                Tecnologia techParaEditar = database.Tecnologias.First(tec => tec.Id == techTemporaria.Id);

                techParaEditar.Nome = techTemporaria.Nome;

                database.SaveChanges();

                return Content("1");

            }
            else
            {

                return Content("0");
            }

        }

    }
}