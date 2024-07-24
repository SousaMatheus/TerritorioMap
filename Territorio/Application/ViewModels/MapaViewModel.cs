using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels
{
    public class MapaViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Número")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public int Numero { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength =3)]
        public int Nome { get; set; }

        public DateTime UltimaVezTrabalhado { get; set; }
        public DateTime PenultimaVezTrabalhado { get; set; }
        public DateTime AntePenultimaVezTrabalhado { get; set; }
        public DateTime PreAntePenultimaVezTrabalhado { get; set; }


        public class Envio : MapaViewModel { }
        public class Retorno : MapaViewModel { }
    }
}
