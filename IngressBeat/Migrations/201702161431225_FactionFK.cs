namespace IngressBeat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FactionFK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Portals", "Owner_ID", "dbo.Factions");
            DropIndex("dbo.Portals", new[] { "Owner_ID" });
            RenameColumn(table: "dbo.Portals", name: "Owner_ID", newName: "Faction");
            AlterColumn("dbo.Portals", "Faction", c => c.Int(nullable: false));
            CreateIndex("dbo.Portals", "Faction");
            AddForeignKey("dbo.Portals", "Faction", "dbo.Factions", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Portals", "Faction", "dbo.Factions");
            DropIndex("dbo.Portals", new[] { "Faction" });
            AlterColumn("dbo.Portals", "Faction", c => c.Int());
            RenameColumn(table: "dbo.Portals", name: "Faction", newName: "Owner_ID");
            CreateIndex("dbo.Portals", "Owner_ID");
            AddForeignKey("dbo.Portals", "Owner_ID", "dbo.Factions", "ID");
        }
    }
}
