using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using desafio_mvc.Models;

namespace desafio_mvc.DTO
{
    public class FuncionarioDTO
    {  
        [Required]
        public int Id { get; set; }
        
        [Required(ErrorMessage="Campo obrigatório")]
        public string Cargo { get; set; }
        
        [Required(ErrorMessage="Campo obrigatório")]
        public DateTime Inicio_wa { get; set; }
        
        [Required(ErrorMessage="Campo obrigatório")]
        public string Matricula { get; set; }
        
        [Required(ErrorMessage="Campo obrigatório")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage="Campo obrigatório")]
        public DateTime Termino_wa { get; set; }
        public int Vaga_Id { get; set; }
        
        [Required(ErrorMessage="Campo obrigatório")]
        public int Gft_Id { get; set; }
        
        [Required(ErrorMessage="Campo obrigatório")]
        public List<int> Listatecnologias { get; set; }

    }
}