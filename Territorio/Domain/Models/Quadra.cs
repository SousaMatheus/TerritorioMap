using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Quadra : Entity
    {
        public int Numero { get; private set; }
        public List<Rua> Ruas { get; private set; }


        [ForeignKey(nameof(Mapa.Id))]
        public int MapaId { get; private set; }
        public Mapa Mapa { get; private set; }
    }
}
