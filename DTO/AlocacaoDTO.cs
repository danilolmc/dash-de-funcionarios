using System;

namespace desafio_mvc.DTO
{
    public class AlocacaoDTO
    {        
        public int Id {get;set;}

        public int Funcionario_Id {get;set;}
        
        public int Vaga_Id {get;set;}

        public DateTime DataAlocacao { get; set; }
    }
}