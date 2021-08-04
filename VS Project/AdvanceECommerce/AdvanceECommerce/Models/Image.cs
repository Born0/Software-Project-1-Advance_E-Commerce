using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AdvanceECommerce.Models
{
    public class Image
    {
        public int ImageId { get; set; }


        [Required(ErrorMessage = "Can't be empty")]
        public int ProductId { get; set; }


        [Required(ErrorMessage = "Can't be empty")]
        public string ImageSource { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}