namespace TreinaWeb.Musicas.AcessoDados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicaoEmailAlbum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ALB_ALBUNS", "ALB_EMAIL", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ALB_ALBUNS", "ALB_EMAIL");
        }
    }
}
