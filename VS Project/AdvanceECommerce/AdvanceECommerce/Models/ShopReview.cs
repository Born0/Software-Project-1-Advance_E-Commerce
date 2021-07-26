using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AdvanceECommerce.Models
{
    public class ShopReview
    {
        public int ShopReviewId { get; set; }
        public int ShopId { get; set; }
        public int CustomerId { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
        [ForeignKey("ShopId")]
        public Shop Shop { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

    }
}