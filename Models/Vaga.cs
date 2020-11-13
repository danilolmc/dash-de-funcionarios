using System;
using System.Collections.Generic;

namespace desafio_mvc.Models
{
    public class Vaga
    {
        public int Id { get; set; }
        public DateTime Abertura_vaga { get; set; }
        public string Codigo_vaga { get; set; }
        public string Descricao_vaga { get; set; }
        public string Projeto { get; set; }
        public int Qtd_vaga { get; set; }
        public bool isActive {get;set;}
        public ICollection<Vaga_tecnologia> VagaTecnologias { get; set; }
    }
}