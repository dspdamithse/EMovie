namespace EMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoneAndHomeCityToTheUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Phone", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "HomeCity", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "HomeCity");
            DropColumn("dbo.AspNetUsers", "Phone");
        }
    }
}
