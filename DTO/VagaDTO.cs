using System.Collections.Generic;
using System;
using desafio_mvc.Models;
using System.ComponentModel.DataAnnotations;

namespace desafio_mvc.DTO
{
    public class VagaDTO
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage="Campo obrigatório")]
        public string Codigo_vaga { get; set; }
        
        [Required(ErrorMessage="Campo obrigatório")]
        public string Descricao_vaga { get; set; }

        [Required(ErrorMessage="Campo obrigatório")]
        public string Projeto { get; set; }

        [Required(ErrorMessage="Campo obrigatório")]
        public int Qtd_vaga { get; set; }
        
        [Required(ErrorMessage="Campo obrigatório")]
        public List<int> Listatecnologias { get; set; }
    }
}