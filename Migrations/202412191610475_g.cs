namespace mvc12122024.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class g : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblEmployees",
                c => new
                    {
                        empid = c.Int(nullable: false, identity: true),
                        empname = c.String(),
                        empage = c.Int(nullable: false),
                        empimage = c.String(),
                    })
                .PrimaryKey(t => t.empid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblEmployees");
        }
    }
}
