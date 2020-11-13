using System.Collections.Generic;
using System;
using System.Linq;
using desafio_mvc.Data;
using desafio_mvc.DTO;
using desafio_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace desafio_mvc.Controllers
{
    public class PopularController : Controller
    {

        private readonly ApplicationDbContext database;

        public PopularController(ApplicationDbContext database)
        {
            this.database = database;
        }

        [HttpPost]
        public IActionResult PopularBanco()
        {

            var temDados = database.Funcionarios.ToList().Count > 0;

            if (!temDados)
            {

                Gft unidadeBarueri = new Gft();

                unidadeBarueri.Cep = "06454000";
                unidadeBarueri.Endereco = "Alameda Rio Negro, 585";
                unidadeBarueri.Cidade = "Barueri";
                unidadeBarueri.Estado = "SP";
                unidadeBarueri.Nome = "Unidade GFT Barueri";
                unidadeBarueri.Telefone = "1121763253";

                Gft unidadeSorocaba = new Gft();

                unidadeSorocaba.Cep = "18095450";
                unidadeSorocaba.Endereco = "Avenida de São Francisco , 96";
                unidadeSorocaba.Cidade = "Sorocaba";
                unidadeSorocaba.Estado = "SP";
                unidadeSorocaba.Nome = "Unidade GFT Sorocaba";
                unidadeSorocaba.Telefone = "1121763253";

                List<Gft> unidades = new List<Gft>();

                unidades.Add(unidadeBarueri);
                unidades.Add(unidadeSorocaba);


                Tecnologia tecnologia = new Tecnologia();
                tecnologia.Nome = "JavaScript";

                Tecnologia tecnologiab = new Tecnologia();
                tecnologiab.Nome = "HTML";

                Tecnologia tecnologiac = new Tecnologia();
                tecnologiac.Nome = "CSS";

                Tecnologia tecnologiad = new Tecnologia();
                tecnologiad.Nome = "C#";

                Tecnologia tecnologiae = new Tecnologia();
                tecnologiae.Nome = "Java";

                Tecnologia tecnologiaf = new Tecnologia();
                tecnologiaf.Nome = "ReactJS";

                Tecnologia tecnologiag = new Tecnologia();
                tecnologiag.Nome = "Angular";

                List<Tecnologia> tecnologias = new List<Tecnologia>();

                tecnologias.Add(tecnologia);
                tecnologias.Add(tecnologiab);
                tecnologias.Add(tecnologiac);
                tecnologias.Add(tecnologiad);
                tecnologias.Add(tecnologiae);
                tecnologias.Add(tecnologiaf);
                tecnologias.Add(tecnologiag);

                Vaga vagaA = new Vaga();

         

                vagaA.Codigo_vaga = "#52584050";
                vagaA.Projeto = "Banco original";
                vagaA.Qtd_vaga = 3;
                vagaA.Abertura_vaga = DateTime.Now;
                vagaA.Descricao_vaga = "Desenvolvedor Mobile";
                vagaA.isActive = true;

                List<Vaga> vagas = new List<Vaga>();

                vagas.Add(vagaA);

                Funcionario funcionarioA = new Funcionario();

                Funcionario_Tecnologia funcionarioATechA = new Funcionario_Tecnologia();

                funcionarioATechA.Funcionario = funcionarioA;
                funcionarioATechA.Tecnologia = tecnologia;

                Funcionario_Tecnologia funcionarioATechB = new Funcionario_Tecnologia();

                funcionarioATechB.Funcionario = funcionarioA;
                funcionarioATechB.Tecnologia = tecnologiab;

                Funcionario_Tecnologia funcionarioATechC = new Funcionario_Tecnologia();

                funcionarioATechC.Funcionario = funcionarioA;
                funcionarioATechC.Tecnologia = tecnologiac;

                List<Funcionario_Tecnologia> funcionarioATech = new List<Funcionario_Tecnologia>();

                funcionarioATech.Add(funcionarioATechA);
                funcionarioATech.Add(funcionarioATechB);
                funcionarioATech.Add(funcionarioATechC);

                funcionarioA.Nome = "Castro Alves";
                funcionarioA.Cargo = "Desenvolvedor Front-end";
                funcionarioA.Matricula = "3412365";
                funcionarioA.Gft = unidadeBarueri;
                funcionarioA.isActive = true;
                funcionarioA.isAlocado = false;
                funcionarioA.Inicio_wa = new DateTime(2020, 11, 10, 9, 45, 0);
                funcionarioA.Termino_wa = new DateTime(2020, 11, 25, 9, 45, 0);
                funcionarioA.FuncionarioTecnologias = funcionarioATech;

                Funcionario funcionarioB = new Funcionario();

                Funcionario_Tecnologia funcionarioBTechA = new Funcionario_Tecnologia();

                funcionarioBTechA.Funcionario = funcionarioB;
                funcionarioBTechA.Tecnologia = tecnologiae;

                Funcionario_Tecnologia funcionarioBTechB = new Funcionario_Tecnologia();

                funcionarioBTechB.Funcionario = funcionarioA;
                funcionarioBTechB.Tecnologia = tecnologiab;

                Funcionario_Tecnologia funcionarioBTechC = new Funcionario_Tecnologia();

                funcionarioBTechC.Funcionario = funcionarioA;
                funcionarioBTechC.Tecnologia = tecnologiac;

                List<Funcionario_Tecnologia> funcionarioBTech = new List<Funcionario_Tecnologia>();

                funcionarioBTech.Add(funcionarioBTechA);
                funcionarioBTech.Add(funcionarioBTechB);
                funcionarioBTech.Add(funcionarioBTechC);

                funcionarioB.Nome = "Ada Lovelace";
                funcionarioB.Cargo = "Desenvolvedora Back-end";
                funcionarioB.Matricula = "6784563";
                funcionarioB.Gft = unidadeSorocaba;
                funcionarioB.isActive = true;
                funcionarioB.isAlocado = false;
                funcionarioB.Inicio_wa = new DateTime(2020, 11, 5, 10, 15, 0);
                funcionarioB.Termino_wa = new DateTime(2020, 11, 20, 10, 15, 0);
                funcionarioB.FuncionarioTecnologias = funcionarioBTech;

                List<Funcionario> funcionarios = new List<Funcionario>();

                funcionarios.Add(funcionarioA);
                funcionarios.Add(funcionarioB);

                database.Tecnologias.AddRange(tecnologias);

                database.Vagas.AddRange(vagas);

                database.Gft.AddRange(unidades);

                database.Funcionarios.AddRange(funcionarios);

                database.SaveChanges();

                var vaga = database.Vagas.First();

                List<Vaga_tecnologia> vagaTe = new List<Vaga_tecnologia>();

                Vaga_tecnologia vagaTeA = new Vaga_tecnologia();

                Vaga_tecnologia vagaTeB = new Vaga_tecnologia();

                vagaTeA.Vaga = vaga;
                vagaTeA.Tecnologia = tecnologiac;

                vagaTeB.Vaga = vaga;
                vagaTeB.Tecnologia = tecnologiad;

                vagaTe.Add(vagaTeA);
                vagaTe.Add(vagaTeB);

                database.Vaga_Tecnologias.AddRange(vagaTe);

                database.SaveChanges();

                return Json("1");
            }else{

                return Json("0");
            }
        }
    }
}