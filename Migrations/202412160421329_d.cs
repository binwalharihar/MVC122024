namespace mvc12122024.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class d : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblGenders", "gender", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblGenders", "gender", c => c.Int(nullable: false));
        }
    }
}
