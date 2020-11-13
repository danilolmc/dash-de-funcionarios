using System.Collections.Generic;
using System;
using System.Linq;
using desafio_mvc.Data;
using desafio_mvc.DTO;
using desafio_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace desafio_mvc.Controllers
{
    public class VagaController : Controller
    {
        private readonly ApplicationDbContext database;

         private readonly UserManager<IdentityUser> _userManager;


        public VagaController(ApplicationDbContext database, UserManager<IdentityUser> userManager)
        {
            this.database = database;
            _userManager = userManager;
        }

        [Route("wa/vagas")]
        
        [Authorize]
        public IActionResult Vagas()
        {

            var vaga = database.Vagas.Where(mvaga => mvaga.isActive && mvaga.Qtd_vaga > 0).Include(v => v.VagaTecnologias).ThenInclude(t => t.Tecnologia);

            return View(vaga.ToList());
        }

        [Route("wa/vagas/cadastrar")]

        [Authorize(Policy= "AccessAdmin")]
        public IActionResult Cadastrar()
        {

            ViewBag.Tecnologia = database.Tecnologias.ToList();

            return View();
        }

        [HttpPost]

        [Authorize(Policy= "AccessAdmin")]
        public IActionResult SalvarVaga(VagaDTO modeloDeDadosVaga)
        {
            if (ModelState.IsValid)
            {

                Vaga vaga = new Vaga();

                var data_atual = DateTime.Now;

                vaga.Abertura_vaga = data_atual;
                vaga.Codigo_vaga = modeloDeDadosVaga.Codigo_vaga;
                vaga.Descricao_vaga = modeloDeDadosVaga.Descricao_vaga;
                vaga.Projeto = modeloDeDadosVaga.Projeto;
                vaga.Qtd_vaga = modeloDeDadosVaga.Qtd_vaga;
                vaga.isActive = true;


                foreach (var vt in modeloDeDadosVaga.Listatecnologias)
                {
                    var tecnologias = database.Tecnologias.First(t => t.Id == vt);

                    Tecnologia t = new Tecnologia();

                    t = tecnologias;

                    Vaga_tecnologia vaga_T = new Vaga_tecnologia();

                    vaga_T.Tecnologia = t;
                    vaga_T.Vaga = vaga;

                    database.Vaga_Tecnologias.Add(vaga_T);

                }

                database.Vagas.Add(vaga);

                database.SaveChanges();

                return RedirectToAction("Vagas");

            }
            else
            {

                ViewBag.Tecnologia = database.Tecnologias.ToList();

                return View("../Vaga/Cadastrar");
            }

        }

        [Authorize(Policy= "AccessAdmin")]
        public IActionResult DeletarVaga(int id)
        {

            Vaga vagaParaDeletar = database.Vagas.First(vaga => vaga.Id == id);

            vagaParaDeletar.isActive = false;

            database.SaveChanges();

            return RedirectToAction("Vagas");

        }


        [Route("wa/vagas/editar/{Id}")]

        [Authorize(Policy= "AccessAdmin")]
        public IActionResult Editar(int id)
        {


            var vagaEditar = database.Vagas.First(v => v.Id == id);

            VagaDTO nvagaDTO = new VagaDTO();

            nvagaDTO.Id = vagaEditar.Id;
            nvagaDTO.Codigo_vaga = vagaEditar.Codigo_vaga;
            nvagaDTO.Descricao_vaga = vagaEditar.Descricao_vaga;
            nvagaDTO.Projeto = vagaEditar.Projeto;
            nvagaDTO.Qtd_vaga = vagaEditar.Qtd_vaga;
            nvagaDTO.Listatecnologias = database.Vaga_Tecnologias.Where(vt => vt.Vaga_Id == vagaEditar.Id).Select(s => s.Tecnologia_Id).ToList();

            ViewBag.Tecnologia = database.Tecnologias.ToList();

            return View(nvagaDTO);
        }

        [HttpPost]

        [Authorize(Policy= "AccessAdmin")]
        public IActionResult SalvarAlteracoes(VagaDTO vagatemporaria)
        {

            if (ModelState.IsValid)
            {

                var vagaEditar = database.Vagas.First(v => v.Id == vagatemporaria.Id);


                vagaEditar.Descricao_vaga = vagatemporaria.Descricao_vaga;
                vagaEditar.Projeto = vagatemporaria.Projeto;
                vagaEditar.Qtd_vaga = vagatemporaria.Qtd_vaga;
                vagaEditar.Qtd_vaga = vagatemporaria.Qtd_vaga;
                
                var vagaAlocacao = database.Alocacoes.Where(v => v.Vaga.Id == vagatemporaria.Id).Include(f => f.Funcionario).ToList();

                Funcionario funcionarioAlocacao = new Funcionario();

                if(vagaAlocacao.Count > 0){

                    funcionarioAlocacao = vagaAlocacao[0].Funcionario;
                    
                    database.Alocacoes.RemoveRange(vagaAlocacao);        

                    database.Funcionarios.Remove(funcionarioAlocacao);        
                }

                database.Vagas.Remove(vagaEditar);

                database.SaveChanges();
                
                foreach (var vt in vagatemporaria.Listatecnologias)
                {
                    var tecnologias = database.Tecnologias.First(t => t.Id == vt);

                    Tecnologia t = new Tecnologia();

                    t = tecnologias;

                    Vaga_tecnologia vaga_T = new Vaga_tecnologia();

                    vaga_T.Tecnologia = t;
                    vaga_T.Vaga = vagaEditar;

                    database.Vaga_Tecnologias.Add(vaga_T);

                }

                if(vagaAlocacao.Count > 0){

                    database.Vagas.Add(vagaEditar);
                
                    database.Funcionarios.Add(funcionarioAlocacao);

                    database.Alocacoes.AddRange(vagaAlocacao);
                }

                database.SaveChanges();

                return RedirectToAction("Vagas");

            }
            else
            {
                ViewBag.Tecnologia = database.Tecnologias.ToList();

                return View("Editar");
            }
        }
    }
}