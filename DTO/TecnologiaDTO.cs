using System.ComponentModel.DataAnnotations;
namespace desafio_mvc.DTO
{
    public class TecnologiaDTO
    {
        [Required]
         public int Id { get; set; }

        [Required(ErrorMessage="Campo obrigatório")]
    
        public string Nome { get; set; }


    }
}