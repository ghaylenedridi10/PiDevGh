namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnaJamilaGhayle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Boutiques",
                c => new
                    {
                        Id_boutique = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Ville = c.String(),
                        Zone = c.String(),
                        Service = c.String(),
                        Heure_ouverture = c.String(),
                        Heure_fermeture = c.String(),
                        Ascisse_X = c.Single(nullable: false),
                        Ordonné_Y = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id_boutique);
            
            CreateTable(
                "dbo.Produits",
                c => new
                    {
                        Id_produit = c.Int(nullable: false, identity: true),
                        Libelle = c.String(),
                        Nom = c.String(),
                        Quantitee = c.Int(nullable: false),
                        Description = c.String(),
                        Image = c.String(),
                        IdPack = c.Int(),
                        Id_categorie = c.Int(),
                        Id_boutique = c.Int(),
                        Id_fichemobile = c.Int(),
                        Panier_IdPanier = c.Int(),
                    })
                .PrimaryKey(t => t.Id_produit)
                .ForeignKey("dbo.Boutiques", t => t.Id_boutique)
                .ForeignKey("dbo.Categories", t => t.Id_categorie)
                .ForeignKey("dbo.FicheTechnique_Mobile", t => t.Id_fichemobile)
                .ForeignKey("dbo.Paniers", t => t.Panier_IdPanier)
                .Index(t => t.Id_categorie)
                .Index(t => t.Id_boutique)
                .Index(t => t.Id_fichemobile)
                .Index(t => t.Panier_IdPanier);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id_categorie = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                    })
                .PrimaryKey(t => t.Id_categorie);
            
            CreateTable(
                "dbo.FicheTechnique_Mobile",
                c => new
                    {
                        Id_fichemobile = c.Int(nullable: false, identity: true),
                        Marque = c.String(),
                        Dimensions = c.String(),
                        Poids = c.Single(nullable: false),
                        Ecrant = c.String(),
                        Definition = c.String(),
                        Photo = c.String(),
                        Os = c.String(),
                        Memoire_interne = c.String(),
                        Micro_sd = c.String(),
                        Connectivite = c.String(),
                        Nfc = c.String(),
                        Soc = c.String(),
                        Ram = c.String(),
                        Capteur_enpreintes = c.String(),
                        Resistance_eau = c.String(),
                        Batterie = c.Int(nullable: false),
                        Port_charge = c.String(),
                        Recharge_rapide = c.String(),
                        Recharge_sansfil = c.String(),
                        Coloris = c.String(),
                        Prix = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id_fichemobile);
            
            CreateTable(
                "dbo.Packs",
                c => new
                    {
                        IdPack = c.Int(nullable: false, identity: true),
                        IdProduit = c.Int(),
                        Image = c.String(),
                        Titre = c.String(),
                        Description = c.String(),
                        DateDebut = c.DateTime(nullable: false),
                        DateFin = c.DateTime(nullable: false),
                        Prix = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.IdPack);
            
            CreateTable(
                "dbo.Commandes",
                c => new
                    {
                        IdCommande = c.Int(nullable: false, identity: true),
                        IdPanier = c.Int(nullable: false),
                        IdUser = c.Int(nullable: false),
                        PrixTotal = c.Single(nullable: false),
                        DateCommand = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdCommande)
                .ForeignKey("dbo.Paniers", t => t.IdPanier, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.IdUser, cascadeDelete: true)
                .Index(t => t.IdPanier)
                .Index(t => t.IdUser);
            
            CreateTable(
                "dbo.Paniers",
                c => new
                    {
                        IdPanier = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(),
                        IdProduit = c.Int(),
                        Quantite = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdPanier)
                .ForeignKey("dbo.Users", t => t.IdUser)
                .Index(t => t.IdUser);
            
            CreateTable(
                "dbo.Devis",
                c => new
                    {
                        IdDevis = c.Int(nullable: false, identity: true),
                        IdPanier = c.Int(),
                        IdUser = c.Int(),
                        PrixTotal = c.Single(nullable: false),
                        DateCommande = c.DateTime(nullable: false),
                        Status = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.IdDevis)
                .ForeignKey("dbo.Paniers", t => t.IdPanier)
                .ForeignKey("dbo.Users", t => t.IdUser)
                .Index(t => t.IdPanier)
                .Index(t => t.IdUser);
            
            CreateTable(
                "dbo.Newslettres",
                c => new
                    {
                        IdNewslettre = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(),
                        MailUser = c.String(),
                        PhoneUser = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdNewslettre)
                .ForeignKey("dbo.Users", t => t.IdUser)
                .Index(t => t.IdUser);
            
            CreateTable(
                "dbo.Offres",
                c => new
                    {
                        IdOffer = c.Int(nullable: false, identity: true),
                        IdProduit = c.Int(),
                        Image = c.String(),
                        Titee = c.String(),
                        Description = c.String(),
                        DateDebut = c.DateTime(nullable: false),
                        DateFin = c.DateTime(nullable: false),
                        Products_Id_produit = c.Int(),
                    })
                .PrimaryKey(t => t.IdOffer)
                .ForeignKey("dbo.Produits", t => t.Products_Id_produit)
                .Index(t => t.Products_Id_produit);
            
            CreateTable(
                "dbo.Promotions",
                c => new
                    {
                        IdPromotion = c.Int(nullable: false, identity: true),
                        IdProduit = c.Int(nullable: false),
                        NewPrice = c.Single(nullable: false),
                        Remise = c.Single(nullable: false),
                        DateFin = c.DateTime(nullable: false),
                        Products_Id_produit = c.Int(),
                    })
                .PrimaryKey(t => t.IdPromotion)
                .ForeignKey("dbo.Produits", t => t.Products_Id_produit)
                .Index(t => t.Products_Id_produit);
            
            CreateTable(
                "dbo.Publicites",
                c => new
                    {
                        IdPublicite = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        Titre = c.String(),
                        Description = c.String(),
                        IdProduct = c.Int(),
                        Produits_Id_produit = c.Int(),
                    })
                .PrimaryKey(t => t.IdPublicite)
                .ForeignKey("dbo.Produits", t => t.Produits_Id_produit)
                .Index(t => t.Produits_Id_produit);
            
            CreateTable(
                "dbo.PacksProduits",
                c => new
                    {
                        Packs_IdPack = c.Int(nullable: false),
                        Produit_Id_produit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Packs_IdPack, t.Produit_Id_produit })
                .ForeignKey("dbo.Packs", t => t.Packs_IdPack, cascadeDelete: true)
                .ForeignKey("dbo.Produits", t => t.Produit_Id_produit, cascadeDelete: true)
                .Index(t => t.Packs_IdPack)
                .Index(t => t.Produit_Id_produit);
            
            AddColumn("dbo.Users", "Nom", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Publicites", "Produits_Id_produit", "dbo.Produits");
            DropForeignKey("dbo.Promotions", "Products_Id_produit", "dbo.Produits");
            DropForeignKey("dbo.Offres", "Products_Id_produit", "dbo.Produits");
            DropForeignKey("dbo.Newslettres", "IdUser", "dbo.Users");
            DropForeignKey("dbo.Devis", "IdUser", "dbo.Users");
            DropForeignKey("dbo.Devis", "IdPanier", "dbo.Paniers");
            DropForeignKey("dbo.Commandes", "IdUser", "dbo.Users");
            DropForeignKey("dbo.Commandes", "IdPanier", "dbo.Paniers");
            DropForeignKey("dbo.Paniers", "IdUser", "dbo.Users");
            DropForeignKey("dbo.Produits", "Panier_IdPanier", "dbo.Paniers");
            DropForeignKey("dbo.PacksProduits", "Produit_Id_produit", "dbo.Produits");
            DropForeignKey("dbo.PacksProduits", "Packs_IdPack", "dbo.Packs");
            DropForeignKey("dbo.Produits", "Id_fichemobile", "dbo.FicheTechnique_Mobile");
            DropForeignKey("dbo.Produits", "Id_categorie", "dbo.Categories");
            DropForeignKey("dbo.Produits", "Id_boutique", "dbo.Boutiques");
            DropIndex("dbo.PacksProduits", new[] { "Produit_Id_produit" });
            DropIndex("dbo.PacksProduits", new[] { "Packs_IdPack" });
            DropIndex("dbo.Publicites", new[] { "Produits_Id_produit" });
            DropIndex("dbo.Promotions", new[] { "Products_Id_produit" });
            DropIndex("dbo.Offres", new[] { "Products_Id_produit" });
            DropIndex("dbo.Newslettres", new[] { "IdUser" });
            DropIndex("dbo.Devis", new[] { "IdUser" });
            DropIndex("dbo.Devis", new[] { "IdPanier" });
            DropIndex("dbo.Paniers", new[] { "IdUser" });
            DropIndex("dbo.Commandes", new[] { "IdUser" });
            DropIndex("dbo.Commandes", new[] { "IdPanier" });
            DropIndex("dbo.Produits", new[] { "Panier_IdPanier" });
            DropIndex("dbo.Produits", new[] { "Id_fichemobile" });
            DropIndex("dbo.Produits", new[] { "Id_boutique" });
            DropIndex("dbo.Produits", new[] { "Id_categorie" });
            DropColumn("dbo.Users", "Nom");
            DropTable("dbo.PacksProduits");
            DropTable("dbo.Publicites");
            DropTable("dbo.Promotions");
            DropTable("dbo.Offres");
            DropTable("dbo.Newslettres");
            DropTable("dbo.Devis");
            DropTable("dbo.Paniers");
            DropTable("dbo.Commandes");
            DropTable("dbo.Packs");
            DropTable("dbo.FicheTechnique_Mobile");
            DropTable("dbo.Categories");
            DropTable("dbo.Produits");
            DropTable("dbo.Boutiques");
        }
    }
}
