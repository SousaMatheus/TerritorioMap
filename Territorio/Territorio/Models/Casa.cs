namespace MapeamentoTerritorio.Models
{
    public class Casa : Entity
    {
        public int Numero { get; set; }
        public string Observacao { get; set; }
        public bool PodeBater { get; set; }
    }
}
