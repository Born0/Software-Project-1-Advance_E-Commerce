using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AdvanceECommerce.Models
{
    public class SalesRecord
    {
        public int SalesRecordId { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Subtotal { get; set; }
        public int ShopId { get; set; }
        public int OrderId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        [ForeignKey("ShopId")]
        public Shop Shop { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

    }
}