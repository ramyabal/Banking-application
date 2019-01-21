using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication.Models
{
    public class TransactionDetails
    {
        public string FromAccountno { get; set; }
        public string ToAccountNo { get; set; }
        public string Amount { get; set; }
    }
}