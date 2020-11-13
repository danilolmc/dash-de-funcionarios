namespace desafio_mvc.Models
{
    public class Vaga_tecnologia
    {

        public int Id { get; set; }
        public int Vaga_Id { get; set; }
        public Vaga Vaga { get; set; }
        public int Tecnologia_Id { get; set; }
        public Tecnologia Tecnologia { get; set; }
    }
}