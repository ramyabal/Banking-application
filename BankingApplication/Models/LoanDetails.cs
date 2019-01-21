using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication.Models
{
    public class LoanDetails
    {
        public string CustomerName { get; set; }
        public string AccountNo { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }
        public string EmailId { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public string AccountBalance { get; set; }
        public string Loans { get; set; }
        public string ApproveLoans { get; set; }
        public string FixedDEposits { get; set; }
        public string ApproveFd { get; set; }
    }
}