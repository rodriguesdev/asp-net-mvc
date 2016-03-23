using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinaWeb.Musicas.Dominio;
using TreinaWeb.Comum.Entity;

namespace TreinaWeb.Musicas.AcessoDados.Entity.TypeConfiguration
{
    class AlbumTypeConfiguration : TreinaWebEntityAbstractConfig<Album>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("ALB_ID");

            Property(p => p.Nome)
                .IsRequired()
                .HasColumnName("ALB_NOME")
                .HasMaxLength(100);

            Property(p => p.Ano)
                .IsRequired()
                .HasColumnName("ALB_ANO");

            Property(p => p.Observacoes)
                .IsOptional()
                .HasColumnName("ALB_OBSERVACOES")
                .HasMaxLength(1000);

            Property(p => p.Email)
                .IsRequired()
                .HasColumnName("ALB_EMAIL")
                .HasMaxLength(100);
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarChaveEstrangeira()
        {
            
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("ALB_ALBUNS");
        }
    }
}
