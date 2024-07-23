using MapeamentoTerritorio.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MapeamentoTerritorio.ViewModels
{
    public class QuadraViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Número")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Numero { get; set; }

        public List<Rua> Ruas { get; set; }


        public class Envio : QuadraViewModel { }
        public class Retorno : QuadraViewModel { }
    }
}
