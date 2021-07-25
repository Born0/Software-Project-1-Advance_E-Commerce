using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AdvanceECommerce.Models
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public int ProviderId { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }
        [ForeignKey("ProviderId")]
        public Shop Shop { get; set; }
        [ForeignKey("ProviderId")]
        public Manager Manager { get; set; }
    }
}