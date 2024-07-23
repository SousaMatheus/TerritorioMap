using MapeamentoTerritorio.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MapeamentoTerritorio.ViewModels
{
    public class RuaViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Endereço")]
        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage ="O campo {0} deve ter entre {2} e {1} caracteres",  MinimumLength = 3)]
        public string Endereco { get; set; }

        [DisplayName("É Comercio?")]
        public bool EhComercio { get; set; }

        [DisplayName("Número Comercial")]
        public string NumeroComercial { get; set; }
        
        public List<Casa> Casas { get; set; }
    }
}
