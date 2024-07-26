using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Rua : Entity
    {
        public string Endereco { get; private set; }


        [ForeignKey(nameof(Quadra.Id))]
        public Guid QuadraId { get; private set; }
        public Quadra Quadra { get; private set; }
        public List<Casa> Casas { get; private set; }
    }
}
