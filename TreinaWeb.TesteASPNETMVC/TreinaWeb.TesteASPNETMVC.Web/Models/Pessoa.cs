using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.TesteASPNETMVC.Web.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [DisplayName("Nome da pessoa:")]
        public string Nome { get; set; }

        [DisplayName("Idade da pessoa:")]
        [Required(ErrorMessage = "O endereço da pessoa é obrigatório")]
        public int Idade { get; set; }

        [DisplayName("Endereço da pessoa:")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O e-mail da pessoa é obrigatório")]
        [DisplayName("E-Mail da pessoa")]
        public string Email { get; set; }



    }
}
