namespace Domain.Models
{
    public class Rua : Entity
    {
        public string Endereco { get; private set; }


        public Guid QuadraId { get; private set; }
        public Quadra Quadra { get; private set; }
        public List<Casa> Casas { get; private set; }
    }
}
