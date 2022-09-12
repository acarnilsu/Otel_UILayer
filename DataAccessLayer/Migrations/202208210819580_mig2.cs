namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "DepartmanID", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "Department_DepartmentID", c => c.Int());
            CreateIndex("dbo.Employees", "Department_DepartmentID");
            AddForeignKey("dbo.Employees", "Department_DepartmentID", "dbo.Departments", "DepartmentID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Department_DepartmentID", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Department_DepartmentID" });
            DropColumn("dbo.Employees", "Department_DepartmentID");
            DropColumn("dbo.Employees", "DepartmanID");
        }
    }
}
