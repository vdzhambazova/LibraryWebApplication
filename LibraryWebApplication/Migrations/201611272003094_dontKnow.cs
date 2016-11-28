namespace LibraryWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dontKnow : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Genre", c => c.Int(nullable: false));
        }
    }
}
