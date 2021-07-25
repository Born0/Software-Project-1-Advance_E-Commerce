using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdvanceECommerce.Models
{
    public class Manager:Person
    {
        public int ManagerId { get; set; }
        public string Role { get; set; }
    }
}