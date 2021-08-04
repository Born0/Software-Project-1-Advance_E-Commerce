namespace AdvanceECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAnnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Shops", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Shops", "ShopManager", c => c.String(nullable: false));
            AlterColumn("dbo.Shops", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Shops", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Shops", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.ShopReviews", "Comment", c => c.String(nullable: false));
            AlterColumn("dbo.ShopReviews", "Image", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ShopReviews", "Image", c => c.String());
            AlterColumn("dbo.ShopReviews", "Comment", c => c.String());
            AlterColumn("dbo.Shops", "Email", c => c.String());
            AlterColumn("dbo.Shops", "Phone", c => c.String());
            AlterColumn("dbo.Shops", "Address", c => c.String());
            AlterColumn("dbo.Shops", "ShopManager", c => c.String());
            AlterColumn("dbo.Shops", "Name", c => c.String());
        }
    }
}
