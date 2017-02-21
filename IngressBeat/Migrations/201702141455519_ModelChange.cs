namespace IngressBeat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelChange : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Portals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PortalName = c.String(),
                        PLat = c.Single(nullable: false),
                        PLong = c.Single(nullable: false),
                        Captured = c.Boolean(nullable: false),
                        Faction = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Portals");
        }
    }
}
