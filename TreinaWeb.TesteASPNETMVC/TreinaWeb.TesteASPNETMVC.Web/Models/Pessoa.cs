using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.TesteASPNETMVC.Web.Models
{
    public class Pessoa
    {
        [DisplayName("Nome da pessoa:")]
        public string Nome { get; set; }
        [DisplayName("Idade da pessoa:")]
        public int Idade { get; set; }
        [DisplayName("Endereço da pessoa:")]
        public string Endereco { get; set; }

    }
}
