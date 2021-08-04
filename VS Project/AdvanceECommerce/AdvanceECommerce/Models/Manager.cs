using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdvanceECommerce.Models
{
    public class Manager:Person
    {
        public int ManagerId { get; set; }


        [Required(ErrorMessage = "Can't be empty")]
        public string ManagerialRole { get; set; }
    }
}