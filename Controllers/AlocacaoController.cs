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
    [Authorize(Policy= "AccessAdmin")]
    public class AlocacaoController : Controller
    {

        private readonly ApplicationDbContext database;

        public AlocacaoController(ApplicationDbContext database)
        {
            this.database = database;
        }



        [Route("wa/alocar/{idFuncionario}")]
        public IActionResult Alocar(int idFuncionario)
        {

            var funcionario = database.Funcionarios
                              .First(func => func.Id == idFuncionario && func.isActive);


            var vagas = database.Vagas
                              .Where(vaga => vaga.Qtd_vaga > 0 && vaga.isActive).Include(v => v.VagaTecnologias).ThenInclude(t => t.Tecnologia);

            ViewBag.Funcionario = funcionario;
            ViewBag.Vagas = vagas;

            return View();

        }


        [HttpPost]
        public IActionResult AlocarFuncionario(AlocacaoDTO alocacaoTemp)
        {
            if (ModelState.IsValid)
            {

                Alocacao alocacao = new Alocacao();

                Funcionario funcionario = database.Funcionarios.First(func => func.Id == alocacaoTemp.Funcionario_Id);

                Vaga vaga = database.Vagas.First(vaga => vaga.Id == alocacaoTemp.Vaga_Id);

                funcionario.Vaga = vaga;

                var dataAlocacao = DateTime.Now;

                alocacao.Funcionario = funcionario;
                alocacao.Vaga = vaga;
                alocacao.DataAlocacao = dataAlocacao;

                database.Alocacoes.Add(alocacao);
                
                vaga.Qtd_vaga -= 1;
                funcionario.isAlocado = true;

                database.SaveChanges();

                return RedirectToAction("Funcionario", "Funcionario");
            }else{

                return Content("Dados invalidos");
            }

        }


    }

}