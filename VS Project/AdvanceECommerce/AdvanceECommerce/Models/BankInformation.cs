using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdvanceECommerce.Models
{
    public class BankInformation
    {
        public int BankInformationId { get; set; }
        public string Name { get; set; }
        public string AccountHolderName { get; set; }
        public string AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string RoutingNumber { get; set; }
        public string ChequeBookImage { get; set; }
    }
}