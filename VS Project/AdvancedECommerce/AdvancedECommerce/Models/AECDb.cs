using AdvancedECommerce.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdvanceECommerce.Models
{
    public class AECDb: DbContext
    {
        public AECDb(): base("Name= AECDb")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AECDb, Configuration>());
        }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<BankInformation> BankInformation  { get; set; }
        public virtual DbSet<Brand> Brands  { get; set; }
        public virtual DbSet<Category> Categories  { get; set; }
        public virtual DbSet< Credential> Credentials  { get; set; }
        public virtual DbSet<Customer> Customers  { get; set; }
        public virtual DbSet<Deliveryman> Deliverymen  { get; set; }
        public virtual DbSet<Discount> Discounts  { get; set; }
        public virtual DbSet<Image> Images  { get; set; }
        public virtual DbSet<Manager> Managers  { get; set; }
        public virtual DbSet<MonthlyExpenditure> MonthlyExpenditures  { get; set; }
        public virtual DbSet<Order> Orders  { get; set; }
        public virtual DbSet<Product> Products  { get; set; }
        public virtual DbSet<ProductDistribution> ProductDistributions  { get; set; }
        public virtual DbSet<SalesRecord> SalesRecords  { get; set; }
        public virtual DbSet<Shop> Shops  { get; set; }
        public virtual DbSet<ShopReview> ShopReviews  { get; set; }
    }
}