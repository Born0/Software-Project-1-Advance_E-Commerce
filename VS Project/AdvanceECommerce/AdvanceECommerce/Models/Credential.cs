using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AdvanceECommerce.Models
{
    public class Credential
    {
        public int CredentialId { get; set; }
        public int UserId { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }

        [ForeignKey("UserId")]
        public Admin Admin { get; set; }
        [ForeignKey("UserId")]
        public Manager Manager { get; set; }
        [ForeignKey("UserId")]
        public Customer Customer { get; set; }
    }
}