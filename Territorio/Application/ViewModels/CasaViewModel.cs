using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels
{
    public class CasaViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Número")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Numero { get; set; }

        [DisplayName("Observação")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} deve ter entre {2} e  {1} caracteres")]
        public string Observacao { get; set; }

        [DisplayName("Pode Bater")]
        public bool PodeBater { get; set; }


        public class Envio : CasaViewModel { }

        public class Retorno : CasaViewModel { }
    }
}
