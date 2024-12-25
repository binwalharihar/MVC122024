namespace mvc12122024.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblRegistrations",
                c => new
                    {
                        rid = c.Int(nullable: false, identity: true),
                        rname = c.String(),
                        remail = c.String(),
                        rpassword = c.String(),
                        rgender = c.Int(nullable: false),
                        rcountry = c.Int(nullable: false),
                        rstate = c.Int(nullable: false),
                        rhobbies = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.rid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblRegistrations");
        }
    }
}
