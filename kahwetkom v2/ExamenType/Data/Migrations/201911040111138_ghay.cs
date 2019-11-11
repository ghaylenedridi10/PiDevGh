namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ghay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Newslettres", "status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Newslettres", "status");
        }
    }
}
