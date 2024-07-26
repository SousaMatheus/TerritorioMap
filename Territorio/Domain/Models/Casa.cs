using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class Casa : Entity
    {
        public int Numero { get; private set; }
        public bool EhComercio { get; private set; }
        public string NumeroComercial { get; private set; }
        public string Observacao { get; private set; }  
        public bool PodeBater { get; private set; }


        [ForeignKey(nameof(Rua.Id))]
        public Guid RuaId { get; private set; }
        public Rua Rua { get; private set; }
    }
}
