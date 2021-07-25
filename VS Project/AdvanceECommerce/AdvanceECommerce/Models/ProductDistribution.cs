using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdvanceECommerce.Models
{
    public class ProductDistribution
    {
        public int ProductDistributionId { get; set; }
        public int ProductId { get; set; }
        public int ShopId { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }
    }
}