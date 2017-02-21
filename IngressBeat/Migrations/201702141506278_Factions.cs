namespace IngressBeat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Factions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Factions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FactionName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Portals", "Owner_ID", c => c.Int());
            CreateIndex("dbo.Portals", "Owner_ID");
            AddForeignKey("dbo.Portals", "Owner_ID", "dbo.Factions", "ID");
            DropColumn("dbo.Portals", "Faction");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Portals", "Faction", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Portals", "Owner_ID", "dbo.Factions");
            DropIndex("dbo.Portals", new[] { "Owner_ID" });
            DropColumn("dbo.Portals", "Owner_ID");
            DropTable("dbo.Factions");
        }
    }
}
