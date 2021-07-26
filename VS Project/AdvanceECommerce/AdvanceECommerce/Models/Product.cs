using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AdvanceECommerce.Models
{
    public class Product
    {
        public  Product()
        {
            ProductDistributions = new HashSet<ProductDistribution>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public string Details { get; set; }
        public double Warranty { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }
       
        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public ICollection<ProductDistribution> ProductDistributions { get; set; }
    }
}