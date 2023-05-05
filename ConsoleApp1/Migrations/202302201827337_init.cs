namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ins_Crs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ins_Id = c.Int(nullable: false),
                        Crs_Id = c.Int(nullable: false),
                        Evaluation = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Crs_Id, cascadeDelete: true)
                .ForeignKey("dbo.Instructors", t => t.Ins_Id, cascadeDelete: true)
                .Index(t => t.Ins_Id)
                .Index(t => t.Crs_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ins_Crs", "Ins_Id", "dbo.Instructors");
            DropForeignKey("dbo.Ins_Crs", "Crs_Id", "dbo.Courses");
            DropIndex("dbo.Ins_Crs", new[] { "Crs_Id" });
            DropIndex("dbo.Ins_Crs", new[] { "Ins_Id" });
            DropTable("dbo.Ins_Crs");
        }
    }
}
