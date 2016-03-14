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
        [MaxLength(50, ErrorMessage ="O nome deve ter no maximo 50 caracteres.")]
        [MinLength(5, ErrorMessage ="O nome deve ter no minimo 5 caracteres.")]
        public string Nome { get; set; }

        [DisplayName("Idade da pessoa:")]
        [Required(ErrorMessage = "O endereço da pessoa é obrigatório")]
        public int Idade { get; set; }

        [DisplayName("Endereço da pessoa:")]
        [MaxLength(100, ErrorMessage = "O endereço deve ter no máximo 100 caracteres")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O e-mail da pessoa é obrigatório")]
        [DisplayName("E-Mail da pessoa")]
        [MaxLength(80, ErrorMessage = "O e-mail deve ter no máximo 20 caracteres")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        public bool Ativo { get; set; }


    }
}
