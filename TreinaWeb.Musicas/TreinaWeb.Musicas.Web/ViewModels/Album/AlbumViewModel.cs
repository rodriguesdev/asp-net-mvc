using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TreinaWeb.Musicas.Web.Annotations;

namespace TreinaWeb.Musicas.Web.ViewModels.Album
{
    public class AlbumViewModel
    {
        [Required(ErrorMessage ="O ID do álbum é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do álbum é obrigatório")]
        [MaxLength(100, ErrorMessage ="O nome do álbum deve conter no máximo 100 caracteres")]
        [Display(Name = "Nome do Album")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O ano do álbum é obrigatório")]
        [Display(Name = "Ano do Album")]
        public int Ano { get; set; }

        [MaxLength(1000, ErrorMessage = "A observação do álbum deve conter no máximo 1000 caracteres")]
        [Display(Name = "Observações")]
        public string Observacoes { get; set; }

        [MaxLength(100, ErrorMessage = "O e-mail  deve conter no máximo 100 caracteres")]
        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        [EmailTreinaWeb(ErrorMessage ="O e-mail deve ser do dominio TreinaWeb")]
        public string Email { get; set; }
    }
}