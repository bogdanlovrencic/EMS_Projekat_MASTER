namespace FTN.Services.NetworkModelService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DeltaSaves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DeltaInfo = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DeltaSaves");
        }
    }
}
