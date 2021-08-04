using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AdvanceECommerce.Models
{
    public class ProductDistribution                            //: DbContext
    {
        public int ProductDistributionId { get; set; }

        [Required(ErrorMessage = "Can't be empty")]
        public int ProductId { get; set; }


        [Required(ErrorMessage = "Can't be empty")]
        public int ShopId { get; set; }


        [Required(ErrorMessage = "Can't be empty")]
        public int Quantity { get; set; }


        [Required(ErrorMessage = "Can't be empty")]
        public bool Status { get; set; }



        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        [ForeignKey("ShopId")]
        public Shop Shop { get; set; }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }*/
    }
}