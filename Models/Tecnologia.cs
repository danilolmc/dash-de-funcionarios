using System.Collections.ObjectModel;
using System.Collections.Generic;
namespace desafio_mvc.Models
{
    public class Tecnologia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Funcionario_Tecnologia> FuncionarioTecnologias { get; set; }
        public ICollection<Vaga_tecnologia> VagaTecnologias { get; set; }

    }
}