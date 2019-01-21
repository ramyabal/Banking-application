using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication.Models
{
    public class ApplyLoanDetails
    {
        public string AccountNo { get; set; }
        public string LoansDropdown { get; set; }
        public string LoanAmount { get; set; }
        public string UploadDocuments { get; set; }
        public string TypeOfEmployment { get; set; }
        public string IncomePerMonth { get; set; }
        public string UploadPayslips { get; set; }
        public string UploadImage { get; set; }
        public string city { get; set; }
        public string LoanApplyDate{ get; set; }

    }
}