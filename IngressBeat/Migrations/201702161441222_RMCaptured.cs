namespace IngressBeat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RMCaptured : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Portals", "Captured");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Portals", "Captured", c => c.Boolean(nullable: false));
        }
    }
}
