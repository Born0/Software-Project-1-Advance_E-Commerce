namespace AdvanceECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "Image", c => c.String());
            AddColumn("dbo.Customers", "Image", c => c.String());
            AddColumn("dbo.Managers", "Image", c => c.String());
            CreateIndex("dbo.Products", "BrandId");
            CreateIndex("dbo.Products", "CategoryId");
            CreateIndex("dbo.Credentials", "UserId");
            CreateIndex("dbo.Discounts", "ProviderId");
            CreateIndex("dbo.Images", "ProductId");
            CreateIndex("dbo.MonthlyExpenditures", "CustomerId");
            CreateIndex("dbo.Orders", "CustomerId");
            CreateIndex("dbo.Orders", "DiscountId");
            CreateIndex("dbo.Orders", "DeliverymanId");
            AddForeignKey("dbo.Products", "BrandId", "dbo.Brands", "BrandId", cascadeDelete: true);
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "CategoryId", cascadeDelete: true);
            AddForeignKey("dbo.Credentials", "UserId", "dbo.Admins", "AdminId", cascadeDelete: true);
            AddForeignKey("dbo.Credentials", "UserId", "dbo.Customers", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.Credentials", "UserId", "dbo.Managers", "ManagerId", cascadeDelete: true);
            AddForeignKey("dbo.Discounts", "ProviderId", "dbo.Managers", "ManagerId", cascadeDelete: true);
            AddForeignKey("dbo.Discounts", "ProviderId", "dbo.Shops", "ShopId", cascadeDelete: true);
            AddForeignKey("dbo.Images", "ProductId", "dbo.Products", "ProductId", cascadeDelete: true);
            AddForeignKey("dbo.MonthlyExpenditures", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "DeliverymanId", "dbo.Deliverymen", "DeliveryManId", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "DiscountId", "dbo.Discounts", "DiscountId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "DiscountId", "dbo.Discounts");
            DropForeignKey("dbo.Orders", "DeliverymanId", "dbo.Deliverymen");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.MonthlyExpenditures", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Images", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Discounts", "ProviderId", "dbo.Shops");
            DropForeignKey("dbo.Discounts", "ProviderId", "dbo.Managers");
            DropForeignKey("dbo.Credentials", "UserId", "dbo.Managers");
            DropForeignKey("dbo.Credentials", "UserId", "dbo.Customers");
            DropForeignKey("dbo.Credentials", "UserId", "dbo.Admins");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Products", "BrandId", "dbo.Brands");
            DropIndex("dbo.Orders", new[] { "DeliverymanId" });
            DropIndex("dbo.Orders", new[] { "DiscountId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.MonthlyExpenditures", new[] { "CustomerId" });
            DropIndex("dbo.Images", new[] { "ProductId" });
            DropIndex("dbo.Discounts", new[] { "ProviderId" });
            DropIndex("dbo.Credentials", new[] { "UserId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropIndex("dbo.Products", new[] { "BrandId" });
            DropColumn("dbo.Managers", "Image");
            DropColumn("dbo.Customers", "Image");
            DropColumn("dbo.Admins", "Image");
        }
    }
}
