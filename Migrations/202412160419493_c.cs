namespace mvc12122024.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class c : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblGenders",
                c => new
                    {
                        gid = c.Int(nullable: false, identity: true),
                        gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.gid);
            
            DropTable("dbo.tblHobbies");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.tblHobbies",
                c => new
                    {
                        hid = c.Int(nullable: false, identity: true),
                        hname = c.String(),
                    })
                .PrimaryKey(t => t.hid);
            
            DropTable("dbo.tblGenders");
        }
    }
}
