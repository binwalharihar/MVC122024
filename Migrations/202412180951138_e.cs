namespace mvc12122024.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class e : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblHobbies",
                c => new
                    {
                        hid = c.Int(nullable: false, identity: true),
                        hname = c.String(),
                    })
                .PrimaryKey(t => t.hid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblHobbies");
        }
    }
}
