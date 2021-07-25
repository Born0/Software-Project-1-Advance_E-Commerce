using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdvanceECommerce.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public string Details { get; set; }
        public double Warranty { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }
        public int ShopId { get; set; }

    }
}