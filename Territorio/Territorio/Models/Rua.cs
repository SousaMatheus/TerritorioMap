namespace MapeamentoTerritorio.Models
{
    public class Rua : Entity
    {
        public string Endereco { get; set; }
        public bool EhComercio { get; set; }
        public string NumeroComercial { get; set; }
        public List<Casa> Casas { get; set; }
    }
}
