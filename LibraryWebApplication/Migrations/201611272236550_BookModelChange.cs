namespace LibraryWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookModelChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "CoverPictureBytes", c => c.Binary(nullable: false));
            DropColumn("dbo.Books", "CoverPicture");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "CoverPicture", c => c.Binary(nullable: false));
            DropColumn("dbo.Books", "CoverPictureBytes");
        }
    }
}
