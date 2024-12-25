namespace mvc12122024.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblRegistrations", "rhobbies", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblRegistrations", "rhobbies", c => c.Int(nullable: false));
        }
    }
}
