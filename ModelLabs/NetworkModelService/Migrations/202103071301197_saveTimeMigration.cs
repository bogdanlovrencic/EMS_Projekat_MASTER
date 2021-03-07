namespace FTN.Services.NetworkModelService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class saveTimeMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DeltaSaves", "AddedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DeltaSaves", "AddedDate");
        }
    }
}
