using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdvanceECommerce.Models
{
    public class Deliveryman: Person
    {
        public int DeliveryManId { get; set; }
        public string Nid { get; set; }
        
        public bool Status { get; set; }
        public double Rating { get; set; }

    }
}