using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApplication
{
    public class Constant
    {
        public static string accountno;
        public static string username;
        public static string menuVal;       
    }
    public class Query
    {
        public static string selectId = "select id from accountT where account_no = ";
        public static string selectAll = "select * from accountT where account_no= ";
        public static string getCount = "select count(*) from accountT";
        public static string selectViewUsers = "select * from [ViewUsers]";
        public static string selectGetLoans = "select * from [GetLoans]";
        public static string getLoansDetails = "select a.account_no,a.loans,a.loan_amount,a.upload_documents,a.type_of_employment,a.income_per_month,a.payslips,a.image,a.city,convert(varchar(50), a.Loan_ApplyDate , 106) as Loan_ApplyDate ,ad.approved_loans from LApply a left join accountT ad on a.account_no = ad.account_no where Loan_ApplyDate between '";
        public static string selectViewLoans =  "select * from [ViewLoans]";
        public static string selectMaxId = "select id from accountT";
        public static string selectAllViewApprove = "select * from [View_approve] where account_no= ";
        public static string selectfd = "select fixed_deposit from accountT where account_no= ";
        public static string selectAllCustomer = "select * from accountT where customer_name ='";
        public static string selectAccountBalance = "select account_balance from accountT where account_no = '";
        public static string selectLoans = "select loans, account_no from accountT where customer_name = '";
        public static string selectFD = "select approved_fd from accountT where account_no= '";
    }
}