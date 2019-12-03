using System.ComponentModel.DataAnnotations;
using System.Web;

namespace JobPageDevFest.Models
{
    public class DadosCandidato
    {
        [Required(ErrorMessage = " Campo nome não pode ser nulo")]
        public string Nome { get; set; }
        [Required(ErrorMessage = " Campo email não pode ser nulo")]
        public string Email { get; set; }
        [Required(ErrorMessage = " Campo Currículo não pode ser nulo")]
        public HttpPostedFileBase Curriculo { get; set; }

    }
}