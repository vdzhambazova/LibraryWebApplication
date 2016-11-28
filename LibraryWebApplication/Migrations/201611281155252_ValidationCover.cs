namespace LibraryWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ValidationCover : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "CoverPictureBytes", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "CoverPictureBytes", c => c.Binary(nullable: false));
        }
    }
}
