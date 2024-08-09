namespace Domain.Models
{
    public class Quadra : Entity
    {
        public int Numero { get; private set; }
        public List<Rua> Ruas { get; private set; }


        public int MapaId { get; private set; }
        public Mapa Mapa { get; private set; }
    }
}
