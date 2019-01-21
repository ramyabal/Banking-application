using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication.Models
{
    public class approveLoans
    {
        public string AccountNo { get; set; }
        public string CustomerName { get; set; }
        public string Loans { get; set; }
        public string LoanAmount { get; set; }
        public string ApproveLoan { get; set; }
    }
}