namespace MapeamentoTerritorio.Models
{
    public class Quadra : Entity
    {
        public int Numero { get; set; }
        public List<Rua> Ruas { get; set; }
    }
}
