using System.ComponentModel.DataAnnotations;

namespace desafio_mvc.DTO
{
    public class GftDTO
    {
        [Required]
        public int Id { get; set; }
        
        [Required(ErrorMessage="Campo obrigatório")]
        [MaxLength(8,ErrorMessage="Digite o CEP sem traços ou espaços")]
        public string Cep { get; set; }

        [Required(ErrorMessage="Campo obrigatório")]
        public string Cidade { get; set; }
        
        [Required(ErrorMessage="Campo obrigatório")]
        public string Endereco { get; set; }
        
        [Required(ErrorMessage="Campo obrigatório")]
        public string Estado { get; set; }

        [Required(ErrorMessage="Campo obrigatório")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage="Campo obrigatório")]
        [MaxLength(8,ErrorMessage="Digite o número sem espaços ou traços")]
        public string Telefone { get; set; }
    }
}