namespace LibraryWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PageCount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "PageCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "PageCount");
        }
    }
}
