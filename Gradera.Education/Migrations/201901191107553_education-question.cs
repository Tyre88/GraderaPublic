namespace Gradera.Education.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class educationquestion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EducationQuestion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EducationId = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        MediaUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Education", t => t.EducationId, cascadeDelete: true)
                .Index(t => t.EducationId);
            
            AddColumn("dbo.Education", "Description", c => c.String());
            DropColumn("dbo.Education", "Data");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Education", "Data", c => c.String());
            DropForeignKey("dbo.EducationQuestion", "EducationId", "dbo.Education");
            DropIndex("dbo.EducationQuestion", new[] { "EducationId" });
            DropColumn("dbo.Education", "Description");
            DropTable("dbo.EducationQuestion");
        }
    }
}
