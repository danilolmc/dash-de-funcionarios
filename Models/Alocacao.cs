using System;
namespace desafio_mvc.Models
{
    public class Alocacao
    {
        public int Id {get;set;}
        public Funcionario Funcionario {get;set;}
        public Vaga Vaga {get;set;}
        public DateTime DataAlocacao { get; set; }
    }
}