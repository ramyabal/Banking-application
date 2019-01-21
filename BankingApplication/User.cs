using BankingApplication.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BankingApplication
{
    public class User
    {
        public void PageLoad()
        {

            string username = null, account_no = null;
            username = Constant.username;
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
                con.Open();

                string getAccountNo = "select account_no from accountT where customer_name ='" + username + "'";
                SqlCommand cmd2 = new SqlCommand(getAccountNo, con);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    account_no = dr2.GetValue(0).ToString();
                    Constant.accountno = account_no;
                }
                dr2.Close();
            }
            finally
            {
                con.Close();
            }
        }
        public DataTable ButtonClick(string username)
        {
            SqlConnection con = new SqlConnection();
            DataTable dt = new DataTable();
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
                con.Open();

                string getDetails = Query.selectAllCustomer + username + "'";
                SqlCommand cmd1 = new SqlCommand(getDetails, con);
                SqlDataReader dr1 = cmd1.ExecuteReader();

                if (dr1.Read())
                {
                    string customer_name = dr1.GetValue(0).ToString();
                    dt.Columns.AddRange(new DataColumn[12] { new DataColumn("Account number", typeof(double)),
                     new DataColumn("Customer name", typeof(string)),
                     new DataColumn("Age",typeof(int)),
                     new DataColumn("Address",typeof(string)),
                     new DataColumn("Email",typeof(string)),
                     new DataColumn("City",typeof(string)),
                     new DataColumn("Gender",typeof(string)),
                     new DataColumn("Account balance",typeof(double)),
                     new DataColumn("Loans",typeof(string)),
                     new DataColumn("Approved Loans",typeof(string)),
                     new DataColumn("Fixed Deposit",typeof(string)),
                     new DataColumn("Approved Fd",typeof(string)) });

                    dt.Rows.Add(dr1.GetValue(0), dr1.GetValue(1), dr1.GetValue(2), dr1.GetValue(3), dr1.GetValue(4), dr1.GetValue(5), dr1.GetValue(6), dr1.GetValue(7), dr1.GetValue(8), dr1.GetValue(9), dr1.GetValue(10), dr1.GetValue(11));
                            
                    dr1.Close();
                }
                return dt;
            }
            finally
            {
                con.Close();
            }
        }

        public void TransferButtonClick(TransactionDetails td)
        {
            double availBalance = 0, amtTransfer = Convert.ToDouble(availBalance);
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
                con.Open();
                string getBalance = Query.selectAccountBalance + Constant.accountno + "'";
                SqlCommand cmd = new SqlCommand(getBalance, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    availBalance = Convert.ToDouble(dr.GetValue(0));
                }
                dr.Close();
                if (availBalance > amtTransfer)
                {
                    SqlCommand cmd1 = new SqlCommand("TransactionDetails", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@FromAccountno", Constant.accountno);
                    cmd1.Parameters.AddWithValue("@ToAccountNo",td.ToAccountNo );
                    cmd1.Parameters.AddWithValue("@Amount", td.Amount);
                    cmd1.ExecuteNonQuery();
                }
            }
            finally
            {
                con.Close();
            }


        }

        public void ApplyLoans(ApplyLoanDetails ad)
        {
            string loan = "", account_no = "";
            string userName = Constant.username;
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
                con.Open();
                string getLoan = Query.selectLoans + userName + "'";
                SqlCommand cmd = new SqlCommand(getLoan, con);
                SqlDataReader dr1 = cmd.ExecuteReader();
                if (dr1.Read())
                {
                    loan = dr1.GetValue(0).ToString();
                    account_no = dr1.GetValue(1).ToString();
                }
                dr1.Close();
                if (loan == "" || loan == null)
                {
                    SqlCommand cmd1 = new SqlCommand("app", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@AccountNo", account_no);
                    cmd1.Parameters.AddWithValue("@Loans", ad.LoansDropdown);
                    cmd1.Parameters.AddWithValue("@LoanAmount", ad.LoanAmount);
                    cmd1.Parameters.AddWithValue("@upload_documents", ad.UploadDocuments);
                    cmd1.Parameters.AddWithValue("@type_of_employment", ad.TypeOfEmployment);
                    cmd1.Parameters.AddWithValue("@income_per_month", ad.IncomePerMonth);
                    cmd1.Parameters.AddWithValue("@payslips", ad.UploadPayslips);
                    cmd1.Parameters.AddWithValue("@image", ad.UploadImage);
                    cmd1.Parameters.AddWithValue("@city", ad.city);
                    cmd1.Parameters.AddWithValue("@LoanApplyDate",Convert.ToDateTime(ad.LoanApplyDate));
                     cmd1.ExecuteNonQuery();

                }
            }

            finally
            {
                con.Close();
            }
        }

        public void ApplyFd(depositdetails dd)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                string accuntno = Constant.accountno, fd = "";
                con.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
                con.Open();

                string selcetAccount = Query.selectFD + dd.AccountNo + "'";
                SqlCommand cmd = new SqlCommand(selcetAccount, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    fd = dr.GetValue(0).ToString();
                }

                if (fd != "no" || fd != "yes")
                {
                    dr.Close();
                    SqlCommand cmd1 = new SqlCommand("applydeposit", con);
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.AddWithValue("@AccountNo", dd.AccountNo);
                    cmd1.Parameters.AddWithValue("@fixedDeposit", dd.DepositAmount);
                    cmd1.ExecuteNonQuery();
                }
            }
            finally
            {
                con.Close();
            }
        }


    }
}
   