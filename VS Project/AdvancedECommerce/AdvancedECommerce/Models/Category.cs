using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;
using System.Collections.Generic;
using AdvanceECommerce.Models;
using System.ComponentModel.DataAnnotations;

namespace AdvanceECommerce
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public int CategoryId { get; set; }


        [Required(ErrorMessage = "Can't be empty")]
        [StringLength(50, ErrorMessage = "Can't be more than 50 character", MinimumLength = 5)]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}