using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections;
using AdvanceECommerce.Models;
using System.Collections.Generic;

namespace AdvanceECommerce
{
    public class Brand
    {
        public Brand() 
        {
            Products = new HashSet<Product>();
        }
        public int BrandId { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; } 
    }
}