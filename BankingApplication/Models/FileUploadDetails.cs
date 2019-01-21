using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication.Models
{
    public class FileUploadDetails
    {
       
        public string AccountNo { get; set; }
        public string Loans { get; set; }
        public string LoanAmount { get; set; }
        public string UploadDocuments{ get; set; }
        public string TypeOfEmployement{ get; set; }
        public string IncomePerMonth{ get; set; }
        public string Payslips{ get; set; }
        public string Image{ get; set; }
        public string City{ get; set; }
        public string LoanApplyDate { get; set; }
        public string ApprovedLoans{ get; set; }
    }
}