namespace desafio_mvc.Models
{

    public class Funcionario_Tecnologia
    {

        public int Id { get; set; }
        // Chaves estrangeiras
        public int Funcionario_Id { get; set; }
        public int Tecnologia_Id { get; set; }
         
        // Propriedades de navegação
        public Funcionario Funcionario { get; set; }
        public Tecnologia Tecnologia { get; set; }


    }
}