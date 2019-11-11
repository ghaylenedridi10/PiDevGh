namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Publicites", name: "Produits_Id_produit", newName: "Products_Id_produit");
            RenameIndex(table: "dbo.Publicites", name: "IX_Produits_Id_produit", newName: "IX_Products_Id_produit");
            AddColumn("dbo.Publicites", "Produit_Id_produit", c => c.Int());
            CreateIndex("dbo.Publicites", "Produit_Id_produit");
            AddForeignKey("dbo.Publicites", "Produit_Id_produit", "dbo.Produits", "Id_produit");
            DropColumn("dbo.Publicites", "IdProduct");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Publicites", "IdProduct", c => c.Int());
            DropForeignKey("dbo.Publicites", "Produit_Id_produit", "dbo.Produits");
            DropIndex("dbo.Publicites", new[] { "Produit_Id_produit" });
            DropColumn("dbo.Publicites", "Produit_Id_produit");
            RenameIndex(table: "dbo.Publicites", name: "IX_Products_Id_produit", newName: "IX_Produits_Id_produit");
            RenameColumn(table: "dbo.Publicites", name: "Products_Id_produit", newName: "Produits_Id_produit");
        }
    }
}
