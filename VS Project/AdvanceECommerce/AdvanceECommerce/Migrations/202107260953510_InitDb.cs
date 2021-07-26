namespace AdvanceECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDb : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Shops", "BankInformationId", c => c.Int(nullable: false));
            CreateIndex("dbo.ProductDistributions", "ProductId");
            CreateIndex("dbo.ProductDistributions", "ShopId");
            CreateIndex("dbo.Shops", "BankInformationId");
            CreateIndex("dbo.SalesRecords", "CustomerId");
            CreateIndex("dbo.SalesRecords", "ProductId");
            CreateIndex("dbo.SalesRecords", "ShopId");
            CreateIndex("dbo.SalesRecords", "OrderId");
            CreateIndex("dbo.ShopReviews", "ShopId");
            CreateIndex("dbo.ShopReviews", "CustomerId");
            AddForeignKey("dbo.ProductDistributions", "ProductId", "dbo.Products", "ProductId", cascadeDelete: true);
            AddForeignKey("dbo.Shops", "BankInformationId", "dbo.BankInformations", "BankInformationId", cascadeDelete: true);
            AddForeignKey("dbo.ProductDistributions", "ShopId", "dbo.Shops", "ShopId", cascadeDelete: true);
            AddForeignKey("dbo.SalesRecords", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.SalesRecords", "OrderId", "dbo.Orders", "OrderId", cascadeDelete: false);
            AddForeignKey("dbo.SalesRecords", "ProductId", "dbo.Products", "ProductId", cascadeDelete: true);
            AddForeignKey("dbo.SalesRecords", "ShopId", "dbo.Shops", "ShopId", cascadeDelete: true);
            AddForeignKey("dbo.ShopReviews", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.ShopReviews", "ShopId", "dbo.Shops", "ShopId", cascadeDelete: true);
            DropColumn("dbo.Products", "ShopId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ShopId", c => c.Int(nullable: false));
            DropForeignKey("dbo.ShopReviews", "ShopId", "dbo.Shops");
            DropForeignKey("dbo.ShopReviews", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.SalesRecords", "ShopId", "dbo.Shops");
            DropForeignKey("dbo.SalesRecords", "ProductId", "dbo.Products");
            DropForeignKey("dbo.SalesRecords", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.SalesRecords", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.ProductDistributions", "ShopId", "dbo.Shops");
            DropForeignKey("dbo.Shops", "BankInformationId", "dbo.BankInformations");
            DropForeignKey("dbo.ProductDistributions", "ProductId", "dbo.Products");
            DropIndex("dbo.ShopReviews", new[] { "CustomerId" });
            DropIndex("dbo.ShopReviews", new[] { "ShopId" });
            DropIndex("dbo.SalesRecords", new[] { "OrderId" });
            DropIndex("dbo.SalesRecords", new[] { "ShopId" });
            DropIndex("dbo.SalesRecords", new[] { "ProductId" });
            DropIndex("dbo.SalesRecords", new[] { "CustomerId" });
            DropIndex("dbo.Shops", new[] { "BankInformationId" });
            DropIndex("dbo.ProductDistributions", new[] { "ShopId" });
            DropIndex("dbo.ProductDistributions", new[] { "ProductId" });
            AlterColumn("dbo.Shops", "BankInformationId", c => c.String());
        }
    }
}
