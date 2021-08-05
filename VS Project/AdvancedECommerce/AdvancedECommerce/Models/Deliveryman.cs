using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdvanceECommerce.Models
{
    public class Deliveryman: Person
    {
        public int DeliveryManId { get; set; }

        [Required(ErrorMessage = "Can't be empty")]
        public string Nid { get; set; }
        public bool Status { get; set; }
        public double Rating { get; set; }

    }
}