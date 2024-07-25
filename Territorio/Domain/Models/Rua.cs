namespace Domain.Models
{
    public class Rua : Entity
    {
        public string Endereco { get; set; }
        public List<Casa> Casas { get; set; }
    }
}
