namespace Domain.Models
{
    public class Mapa : Entity
    {
        public int Numero { get; private set; }
        public string Nome { get; private set; }
        public DateTime UltimaVezTrabalhado { get; private set; }
        public DateTime PenultimaVezTrabalhado { get; private set; }
        public DateTime AntePenultimaVezTrabalhado { get; private set; }
        public DateTime PreAntePenultimaVezTrabalhado { get; private set; }

        public List<Quadra> Quadras { get; private set; }
    }
}
