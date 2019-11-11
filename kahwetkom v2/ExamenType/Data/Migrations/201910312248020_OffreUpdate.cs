namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OffreUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Offres", "Produit_Id_produit", c => c.Int());
            CreateIndex("dbo.Offres", "Produit_Id_produit");
            AddForeignKey("dbo.Offres", "Produit_Id_produit", "dbo.Produits", "Id_produit");
            DropColumn("dbo.Offres", "IdProduit");
            DropColumn("dbo.Offres", "Image");
            DropColumn("dbo.Offres", "Titee");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Offres", "Titee", c => c.String());
            AddColumn("dbo.Offres", "Image", c => c.String());
            AddColumn("dbo.Offres", "IdProduit", c => c.Int());
            DropForeignKey("dbo.Offres", "Produit_Id_produit", "dbo.Produits");
            DropIndex("dbo.Offres", new[] { "Produit_Id_produit" });
            DropColumn("dbo.Offres", "Produit_Id_produit");
        }
    }
}
