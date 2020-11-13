using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using desafio_mvc.Data;
using System.Linq;
using desafio_mvc.DTO;
using desafio_mvc.Models;
using Microsoft.AspNetCore.Authorization;

namespace desafio_mvc.Controllers
{
    [Authorize(Policy = "AccessAdmin")]
    public class GftController : Controller

    {
        private readonly ApplicationDbContext database;

        public GftController(ApplicationDbContext database)
        {
            this.database = database;
        }


        [Route("wa/unidadesgft")]
        public IActionResult Unidades()
        {

            var unidades = database.Gft.ToList();

            return View(unidades);
        }


        [Route("wa/unidadesgft/cadastrar")]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]

        public IActionResult SalvarUnidade(GftDTO gfdadosTemporarios)
        {

            if (ModelState.IsValid)
            {
                var UnidadeJáExiste = database.Gft.Where(gft => gft.Cep == gfdadosTemporarios.Cep).ToList().Count() > 0;

                if (UnidadeJáExiste)
                {
                    return RedirectToAction("Cadastrar");
                }
                else
                {


                    Gft gft = new Gft();

                    gft.Cep = gfdadosTemporarios.Cep;
                    gft.Endereco = gfdadosTemporarios.Endereco;
                    gft.Cidade = gfdadosTemporarios.Cidade;
                    gft.Estado = gfdadosTemporarios.Estado;
                    gft.Nome = gfdadosTemporarios.Nome;
                    gft.Telefone = gfdadosTemporarios.Telefone;

                    database.Gft.Add(gft);

                    database.SaveChanges();

                }

                return RedirectToAction("Unidades");
            }
            else
            {

                return View("../unidadesgft/cadastrar");
            }
        }


        [Route("wa/unidadesgft/editar/{idUnidade}")]
        public IActionResult Editar(int idUnidade)
        {

            var unidadeEditar = database.Gft.First(gft => gft.Id == idUnidade);


            GftDTO gftDTO = new GftDTO();

            gftDTO.Id = unidadeEditar.Id;
            gftDTO.Cep = unidadeEditar.Cep;
            gftDTO.Cidade = unidadeEditar.Cidade;
            gftDTO.Endereco = unidadeEditar.Endereco;
            gftDTO.Estado = unidadeEditar.Estado;
            gftDTO.Nome = unidadeEditar.Nome;
            gftDTO.Telefone = unidadeEditar.Telefone;

            return View(gftDTO);
        }


        [HttpPost]
        public IActionResult SalvarAlteracoesUnidade(GftDTO unidadeTemporaria)
        {

            if (ModelState.IsValid)
            {

                var unidadeEditar = database.Gft.First(gft => gft.Id == unidadeTemporaria.Id);

                unidadeEditar.Nome = unidadeTemporaria.Nome;
                unidadeEditar.Cep = unidadeTemporaria.Cep;
                unidadeEditar.Endereco = unidadeTemporaria.Endereco;
                unidadeEditar.Cidade = unidadeTemporaria.Cidade;
                unidadeEditar.Estado = unidadeTemporaria.Estado;
                unidadeEditar.Endereco = unidadeTemporaria.Endereco;
                unidadeEditar.Telefone = unidadeTemporaria.Telefone;

                database.SaveChanges();

                return RedirectToAction("Unidades");

            }
            else
            {
                return View("Editar");
            }
        }
    }
}