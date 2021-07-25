using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AdvanceECommerce.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public double AddedSubtotal { get; set; }
        public int DiscountId { get; set; }
        public double GrandTotal { get; set; }
        public int DeliverymanId { get; set; }
        public bool DeliveryStatus { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        [ForeignKey("DiscountId")]
        public Discount Discount { get; set; }
        [ForeignKey("DeliverymanId")]
        public Deliveryman Deliveryman { get; set; }
    }
}