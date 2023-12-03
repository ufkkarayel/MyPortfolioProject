namespace MyPortfolioProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_projectandcategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Projects", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Projects", new[] { "CategoryID" });
            DropTable("dbo.Projects");
            DropTable("dbo.Categories");
        }
    }
}
