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
    public class HistoricoController : Controller
    {
        private readonly ApplicationDbContext database;

        public HistoricoController(ApplicationDbContext database)
        {
            this.database = database;
        }


        [Route("wa/historico")]
        public IActionResult Historico()
        {

            var alocacao = database.Alocacoes.Where(f => f.Id > 0).Include(alf => alf.Funcionario).Include(alv => alv.Vaga);

            ViewBag.Historico = alocacao;

            return View();
        }
    }
}