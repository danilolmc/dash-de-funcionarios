using System.Collections.Generic;
using System;
using System.Linq;
using desafio_mvc.Data;
using desafio_mvc.DTO;
using desafio_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace desafio_mvc.Controllers
{
    public class FuncionarioController : Controller
    {

        private readonly ApplicationDbContext database;
        private readonly UserManager<IdentityUser> _userManager;

        public FuncionarioController(ApplicationDbContext database, UserManager<IdentityUser> userManager)
        {
            this.database = database;
            _userManager = userManager;
        }

        [Authorize]
        [Route("wa/funcionarios")]
        public async Task<IActionResult> Funcionario()
        {

            var funcionario = database.Funcionarios.Where(func => func.isActive && !func.isAlocado).Include(f => f.FuncionarioTecnologias).ThenInclude(t => t.Tecnologia);

            var user = await _userManager.GetUserAsync(User);

            return View(funcionario.ToList());
        }

        [Authorize(Policy = "AccessAdmin")]

        [Route("wa/funcionarios/cadastrar")]
        public IActionResult Cadastrar()
        {
            ViewBag.Tecnologia = database.Tecnologias.ToList();
            ViewBag.Unidades = database.Gft.ToList();

            return View();
        }


        [HttpPost]

        [Authorize(Policy = "AccessAdmin")]
        public IActionResult SalvarFuncionario(FuncionarioDTO modeloDeDadosFunc)
        {
            if (ModelState.IsValid)
            {


                Funcionario funcionario = new Funcionario();

                funcionario.Cargo = modeloDeDadosFunc.Cargo;
                funcionario.Inicio_wa = modeloDeDadosFunc.Inicio_wa;
                funcionario.Matricula = modeloDeDadosFunc.Matricula;
                funcionario.Nome = modeloDeDadosFunc.Nome;
                funcionario.Termino_wa = modeloDeDadosFunc.Termino_wa;
                funcionario.isActive = true;
                funcionario.isAlocado = false;

                foreach (var vt in modeloDeDadosFunc.Listatecnologias)
                {
                    var tecnologias = database.Tecnologias.First(t => t.Id == vt);

                    Tecnologia t = new Tecnologia();

                    t = tecnologias;

                    Funcionario_Tecnologia func_T = new Funcionario_Tecnologia();

                    func_T.Tecnologia = t;
                    func_T.Funcionario = funcionario;

                    database.Funcionario_Tecnologias.Add(func_T);

                }

                funcionario.Gft = database.Gft.First(gftFilial => gftFilial.Id == modeloDeDadosFunc.Gft_Id);

                database.Funcionarios.Add(funcionario);

                database.SaveChanges();

                return RedirectToAction("Funcionario");

            }
            else
            {

                ViewBag.Tecnologia = database.Tecnologias.ToList();
                ViewBag.Unidades = database.Gft.ToList();
                return View("../Funcionario/Cadastrar");
            }

        }

        [Authorize(Policy = "AccessAdmin")]

        public IActionResult DeletarFuncionario(int idf)
        {

            Funcionario funcionarioParaDeletar = database.Funcionarios.First(func => func.Id == idf);

            funcionarioParaDeletar.isActive = false;

            // var ftd = database.Funcionario_Tecnologias.Where(ft => ft.Funcionario_Id == funcionarioParaDeletar.Id).ToList();

            // foreach (var funcionarioT in ftd)
            // {
            //     Tecnologia td = database.Tecnologias.First(t => t.Id == funcionarioT.Tecnologia_Id);
            //     database.Tecnologias.Remove(td);
            // }

            // database.Funcionarios.Remove(funcionarioParaDeletar);

            database.SaveChanges();

            return RedirectToAction("Funcionario");

        }

        [Route("wa/funcionario/editar/{Id}")]

        [Authorize(Policy = "AccessAdmin")]

        public IActionResult Editar(int id)
        {

            var funcionarioEditar = database.Funcionarios.Where(v => v.Id == id).Include(f => f.Gft).ToList()[0];


            FuncionarioDTO nfuncDTO = new FuncionarioDTO();

            nfuncDTO.Id = funcionarioEditar.Id;
            nfuncDTO.Nome = funcionarioEditar.Nome;
            nfuncDTO.Cargo = funcionarioEditar.Cargo;
            nfuncDTO.Inicio_wa = funcionarioEditar.Inicio_wa;
            nfuncDTO.Termino_wa = funcionarioEditar.Termino_wa;
            nfuncDTO.Matricula = funcionarioEditar.Matricula;
            nfuncDTO.Vaga_Id = 0;

            var GftID = funcionarioEditar;

            nfuncDTO.Gft_Id = funcionarioEditar.Gft.Id;

            nfuncDTO.Listatecnologias = database.Funcionario_Tecnologias.Where(ft => ft.Funcionario_Id == funcionarioEditar.Id).Select(s => s.Tecnologia_Id).ToList();

            ViewBag.Tecnologia = database.Tecnologias.ToList();
            ViewBag.Unidades = database.Gft.ToList();

            return View(nfuncDTO);
        }


        [HttpPost]

        [Authorize(Policy = "AccessAdmin")]
        public IActionResult SalvarAlteracoesFunc(FuncionarioDTO funcionarioTemporario)
        {

            if (ModelState.IsValid)
            {

                var funcEditar = database.Funcionarios.First(v => v.Id == funcionarioTemporario.Id);

                funcEditar.Nome = funcionarioTemporario.Nome;
                funcEditar.Cargo = funcionarioTemporario.Cargo;
                funcEditar.Inicio_wa = funcionarioTemporario.Inicio_wa;
                funcEditar.Termino_wa = funcionarioTemporario.Termino_wa;
                funcEditar.Matricula = funcionarioTemporario.Matricula;
                funcEditar.Gft = database.Gft.First(gft => gft.Id == funcionarioTemporario.Gft_Id);

                database.Funcionarios.Remove(funcEditar);

                database.SaveChanges();

                foreach (var vt in funcionarioTemporario.Listatecnologias)
                {
                    var tecnologias = database.Tecnologias.First(t => t.Id == vt);

                    Tecnologia t = new Tecnologia();

                    t = tecnologias;

                    Funcionario_Tecnologia func_T = new Funcionario_Tecnologia();

                    func_T.Tecnologia = t;
                    func_T.Funcionario = funcEditar;

                    database.Funcionario_Tecnologias.Add(func_T);

                }

                database.Funcionarios.Add(funcEditar);

                database.SaveChanges();

                return RedirectToAction("Funcionario");

            }
            else
            {
                ViewBag.Tecnologia = database.Tecnologias.ToList();
                ViewBag.Unidades = database.Gft.ToList();

                return View("Editar");
            }
        }


    }
}