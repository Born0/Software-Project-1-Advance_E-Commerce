using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AdvanceECommerce.Models
{
    public class MonthlyExpenditure
    {
        public int MonthlyExpenditureId { get; set; }
        public int CustomerId { get; set; }
        public double Minimum { get; set; }
        public double Maximum { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
    }
}