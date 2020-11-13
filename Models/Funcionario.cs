using System;
using System.Collections.Generic;

namespace desafio_mvc.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Cargo { get; set; }
        public DateTime Inicio_wa { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public DateTime Termino_wa { get; set; }
        public Vaga Vaga { get; set; }
        public Gft Gft { get; set; }
        public bool isActive { get; set; }
        public ICollection<Funcionario_Tecnologia> FuncionarioTecnologias { get; set; }
        public ICollection<Alocacao> Alocacao_Funcionario { get; set; }
        public bool isAlocado { get; set; }

    }
}