namespace mvc12122024.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCountries",
                c => new
                    {
                        cid = c.Int(nullable: false, identity: true),
                        cname = c.String(),
                    })
                .PrimaryKey(t => t.cid);
            
            CreateTable(
                "dbo.tblHobbies",
                c => new
                    {
                        hid = c.Int(nullable: false, identity: true),
                        hname = c.String(),
                    })
                .PrimaryKey(t => t.hid);
            
            CreateTable(
                "dbo.tblStates",
                c => new
                    {
                        sid = c.Int(nullable: false, identity: true),
                        cid = c.Int(nullable: false),
                        sname = c.String(),
                    })
                .PrimaryKey(t => t.sid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblStates");
            DropTable("dbo.tblHobbies");
            DropTable("dbo.tblCountries");
        }
    }
}
