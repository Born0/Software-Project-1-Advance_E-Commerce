using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections;
using AdvanceECommerce.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdvanceECommerce
{
    public class Brand
    {
        public Brand() 
        {
            Products = new HashSet<Product>();
        }
        public int BrandId { get; set; }


        [Required(ErrorMessage = "Can't be empty")]
        [StringLength(50, ErrorMessage = "Can't be more than 50 character", MinimumLength = 1)]
        public string Name { get; set; }



        public ICollection<Product> Products { get; set; } 
    }
}