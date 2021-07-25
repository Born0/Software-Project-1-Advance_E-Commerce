using System;
using System.Collections.Generic;
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
    }
}