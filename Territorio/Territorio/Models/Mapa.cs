namespace MapeamentoTerritorio.Models
{
    public class Mapa : Entity
    {
        public int Numero { get; set; }
        public int Nome { get; set; }
        public DateTime UltimaVezTrabalhado { get; set; }
        public DateTime PenultimaVezTrabalhado { get; set; }
        public DateTime AntePenultimaVezTrabalhado { get; set; }
        public DateTime PreAntePenultimaVezTrabalhado { get; set; }
    }
}
