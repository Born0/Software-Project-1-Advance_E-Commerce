using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdvanceECommerce.Models
{
    public class DeliverymanReview
    {
        public int DeliveryManReviewId { get; set; }
        public int DeliveryManId { get; set; }
        public int CustomerId { get; set; }
        public string Comment { get; set; }
        [ForeignKey("DeliveryManId")]
        public Deliveryman  Deliveryman { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
    }
}