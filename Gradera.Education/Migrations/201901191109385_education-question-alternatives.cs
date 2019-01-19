namespace Gradera.Education.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class educationquestionalternatives : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EducationQuestionAlternative",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EducationQuestionId = c.Int(nullable: false),
                        Text = c.String(),
                        IsCorrect = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EducationQuestion", t => t.EducationQuestionId, cascadeDelete: true)
                .Index(t => t.EducationQuestionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EducationQuestionAlternative", "EducationQuestionId", "dbo.EducationQuestion");
            DropIndex("dbo.EducationQuestionAlternative", new[] { "EducationQuestionId" });
            DropTable("dbo.EducationQuestionAlternative");
        }
    }
}
