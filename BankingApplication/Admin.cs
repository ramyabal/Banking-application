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
    public class Admin
    {
        public IList<GetAccountDetails> ViewUsers()
        {
            SqlConnection con = new SqlConnection();
            DataTable dt = new DataTable();
            IList<GetAccountDetails> accountDetailList = new List<GetAccountDetails>();

            try
            {
                int rowCount = 0;
                con.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
                con.Open();
                string getRowNo = Query.getCount;
                SqlCommand cmd = new SqlCommand(getRowNo, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    rowCount = Convert.ToInt32(dr.GetValue(0));
                }
                dr.Close();
                string getDetails = Query.selectViewUsers;
                SqlCommand cmd1 = new SqlCommand(getDetails, con);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                dt.Columns.AddRange(new DataColumn[8] { new DataColumn("Account number", typeof(string)),
                             new DataColumn("Customer name", typeof(string)),
                             new DataColumn("Age",typeof(string)),
                             new DataColumn("Address",typeof(string)),
                             new DataColumn("Email",typeof(string)),
                             new DataColumn("City",typeof(string)),
                             new DataColumn("Gender",typeof(string)),
                             new DataColumn("Account balance",typeof(string))});
                while (dr1.Read())
                {
                    GetAccountDetails detail = new GetAccountDetails();

                        detail.AccountNo = Convert.ToString(dr1["account_no"]);
                        detail.CustomerName = Convert.ToString(dr1["customer_name"]);
                        detail.Age = Convert.ToString(dr1["age"]);
                        detail.Address = Convert.ToString(dr1["address"]);
                        detail.EmailId = Convert.ToString(dr1["email_id"]);
                        detail.City = Convert.ToString(dr1["city"]);
                        detail.Gender = Convert.ToString(dr1["gender"]);
                        detail.AccountBalance = Convert.ToString(dr1["account_balance"]);
                        accountDetailList.Add(detail);
                        
                }
                dr1.Close();
            }

            finally
            {
                con.Close();
            }
            return accountDetailList;
        }

        public IList<GetAccountDetails> ListViewUsers()
        {
            return this.ViewUsers();
        }

        public IList<FileUploadDetails> GetLoans()
        {
            SqlConnection con = new SqlConnection();
            DataTable dt = new DataTable();
            IList<FileUploadDetails> FileUploadDetailsList = new List<FileUploadDetails>();
            try
            {

                con.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
                con.Open();
                string getDetails = Query.selectGetLoans;
                SqlCommand cmd1 = new SqlCommand(getDetails, con);
                SqlDataReader dr1 = cmd1.ExecuteReader();

                dt.Columns.AddRange(new DataColumn[11]{ new DataColumn("Account number", typeof(string)),
                     new DataColumn("Loans", typeof(string)),
                     new DataColumn("Loan Amount",typeof(string)),
                     new DataColumn("upload Documents",typeof(string)),
                     new DataColumn("Type Of Employement",typeof(string)),
                     new DataColumn("Income Per month",typeof(string)),
                     new DataColumn("Payslips",typeof(string)),
                     new DataColumn("Image",typeof(string)),
                     new DataColumn("City",typeof(string)),
                     new DataColumn("LoanApplyDate",typeof(string)),
                     new DataColumn("Approved Loans",typeof(string))});
                while (dr1.Read())
                {
                    FileUploadDetails detail = new FileUploadDetails();

                    detail.AccountNo = Convert.ToString(dr1["account_no"]);
                    detail.Loans = Convert.ToString(dr1["loans"]);
                    detail.LoanAmount = Convert.ToString(dr1["loan_amount"]);
                    detail.UploadDocuments = Convert.ToString(dr1["upload_documents"]);
                    detail.TypeOfEmployement = Convert.ToString(dr1["type_of_employment"]);
                    detail.IncomePerMonth = Convert.ToString(dr1["income_per_month"]);
                    detail.Payslips = Convert.ToString(dr1["payslips"]);
                    detail.Image = Convert.ToString(dr1["image"]);
                    detail.City = Convert.ToString(dr1["city"]);
                    detail.LoanApplyDate = Convert.ToString(dr1["Loan_ApplyDate"]);
                    detail.ApprovedLoans = Convert.ToString(dr1["approved_loans"]);
                    FileUploadDetailsList.Add(detail);
                }
                dr1.Close();
            }

            finally
            {
                con.Close();
            }
            return FileUploadDetailsList;
        }
      
        public IList<FileUploadDetails> ListGetLoans()
        {
            return this.GetLoans();
        }

        public IList<FileUploadDetails> GetLoans(string fromdt,string todt)
        {
            SqlConnection con = new SqlConnection();
            DataTable dt = new DataTable();
            IList<FileUploadDetails> FileUploadDetailsList = new List<FileUploadDetails>();
            try
            {

                con.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
                con.Open();
                string getDetails = Query.getLoansDetails + fromdt + "' and '" + todt + "'";
                SqlCommand cmd1 = new SqlCommand(getDetails, con);
                SqlDataReader dr1 = cmd1.ExecuteReader();

                dt.Columns.AddRange(new DataColumn[11]{ new DataColumn("Account number", typeof(string)),
                     new DataColumn("Loans", typeof(string)),
                     new DataColumn("Loan Amount",typeof(string)),
                     new DataColumn("upload Documents",typeof(string)),
                     new DataColumn("Type Of Employement",typeof(string)),
                     new DataColumn("Income Per month",typeof(string)),
                     new DataColumn("Payslips",typeof(string)),
                     new DataColumn("Image",typeof(string)),
                     new DataColumn("City",typeof(string)),
                     new DataColumn("LoanApplyDate",typeof(string)),
                     new DataColumn("Approved Loans",typeof(string))});
                while (dr1.Read())
                {
                    FileUploadDetails detail = new FileUploadDetails();

                    detail.AccountNo = Convert.ToString(dr1["account_no"]);
                    detail.Loans = Convert.ToString(dr1["loans"]);
                    detail.LoanAmount = Convert.ToString(dr1["loan_amount"]);
                    detail.UploadDocuments = Convert.ToString(dr1["upload_documents"]);
                    detail.TypeOfEmployement = Convert.ToString(dr1["type_of_employment"]);
                    detail.IncomePerMonth = Convert.ToString(dr1["income_per_month"]);
                    detail.Payslips = Convert.ToString(dr1["payslips"]);
                    detail.Image = Convert.ToString(dr1["image"]);
                    detail.City = Convert.ToString(dr1["city"]);
                    detail.LoanApplyDate = Convert.ToString(dr1["Loan_ApplyDate"]);
                    detail.ApprovedLoans = Convert.ToString(dr1["approved_loans"]);
                    FileUploadDetailsList.Add(detail);
                }
                dr1.Close();
            }

            finally
            {
                con.Close();
            }
            return FileUploadDetailsList;
        }
        public IList<FileUploadDetails> ListGetLoans(string fromdt, string todt)
        {
            return this.GetLoans(fromdt, todt);
        }




        public IList<LoanDetails> ViewLoans()
        {
            SqlConnection con = new SqlConnection();
            DataTable dt = new DataTable();
            IList<LoanDetails> LoansDetailList = new List<LoanDetails>();
            try
            {

                con.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
                con.Open();
                string getDetails = Query.selectViewLoans;
                SqlCommand cmd1 = new SqlCommand(getDetails, con);
                SqlDataReader dr1 = cmd1.ExecuteReader();

                dt.Columns.AddRange(new DataColumn[12] { new DataColumn("Account number", typeof(string)),
                     new DataColumn("Customer name", typeof(string)),
                     new DataColumn("Age",typeof(string)),
                     new DataColumn("Address",typeof(string)),
                     new DataColumn("Email",typeof(string)),
                     new DataColumn("City",typeof(string)),
                     new DataColumn("Gender",typeof(string)),
                     new DataColumn("Account balance",typeof(string)),
                     new DataColumn("Loans",typeof(string)),
                     new DataColumn("Approved Loans",typeof(string)),
                     new DataColumn("Fixed Deposit",typeof(string)),
                     new DataColumn("Approved Fd",typeof(string))});
                while (dr1.Read())
                {
                    LoanDetails detail = new LoanDetails();

                    detail.AccountNo = Convert.ToString(dr1["account_no"]);
                    detail.CustomerName = Convert.ToString(dr1["customer_name"]);
                    detail.Age = Convert.ToString(dr1["age"]);
                    detail.Address = Convert.ToString(dr1["address"]);
                    detail.EmailId = Convert.ToString(dr1["email_id"]);
                    detail.City = Convert.ToString(dr1["city"]);
                    detail.Gender = Convert.ToString(dr1["gender"]);
                    detail.AccountBalance = Convert.ToString(dr1["account_balance"]);
                    detail.Loans = Convert.ToString(dr1["loans"]);
                    detail.ApproveLoans = Convert.ToString(dr1["approved_loans"]);
                    detail.FixedDEposits = Convert.ToString(dr1["fixed_deposit"]);
                    detail.ApproveFd = Convert.ToString(dr1["approved_fd"]);
                    LoansDetailList.Add(detail);
                }
                dr1.Close();
            }

            finally
            {
                con.Close();
            }
            return LoansDetailList;
        }
        public IList<LoanDetails> ListViewLoans()
        {
            return this.ViewLoans();
        }

       public void CreateUser(AccountDetails Ad)
        {
            //string Customername="";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
                con.Open();
                long count = 12345;
                int id = 0, temp = 0, id1 = 0;
                string getId = Query.selectMaxId;
                SqlCommand cmd1 = new SqlCommand(getId, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    getId = dr.GetValue(0).ToString();
                    id = Convert.ToInt32(getId);
                    if (temp < id)
                    {
                        id1 = id;
                        temp = id;
                    }
                }
                dr.Close();
                id1 = id1 + 1;

                string accountNo = String.Concat(count, id1);

                string getUname = "select * from loginT where username = '" + Ad.CustomerName + "'";
                SqlCommand cmdGetUname = new SqlCommand(getUname, con);
                SqlDataReader dr1 = cmdGetUname.ExecuteReader();
                if (!dr1.HasRows)
                {
                    dr1.Close();
                    string insertLogin = "insert into loginT values('" + Ad.CustomerName + "','" + Ad.password + "','" + id1 + "','no')";
                    SqlCommand cmdLogin = new SqlCommand(insertLogin, con);
                    cmdLogin.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand("createdetails", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Accountno", accountNo);
                    cmd.Parameters.AddWithValue("@Customername", Ad.CustomerName);
                    cmd.Parameters.AddWithValue("@Age", Ad.Age);
                    cmd.Parameters.AddWithValue("@Address", Ad.Address);
                    cmd.Parameters.AddWithValue("@Emailid", Ad.EmailId);
                    cmd.Parameters.AddWithValue("@City", Ad.City);
                   cmd.Parameters.AddWithValue("@Gender", Ad.Gender);
                   cmd.Parameters.AddWithValue("@Accountbalance", Ad.AccountBalance);
                   cmd.Parameters.AddWithValue("@id", id1);
                   cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                con.Close();
            }
        }

       public UpdateDetails updatepageload()
       {

           return getDetails();

       }
        private UpdateDetails getDetails()
        {

            UpdateDetails ud = new UpdateDetails();
           SqlConnection conn = new SqlConnection();
           try
           {
              
               conn.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
               conn.Open();
               string selcetAccount = Query.selectAll +Constant.accountno;
               SqlCommand cmd = new SqlCommand(selcetAccount, conn);
               SqlDataReader dr = cmd.ExecuteReader();
               if (dr.Read())
               {
                   ud.CustomerName = dr.GetValue(1).ToString();
                   ud.Age = dr.GetValue(2).ToString();
                   ud.Address = dr.GetValue(3).ToString();
                   ud.EmailId = dr.GetValue(4).ToString();
                   ud.City = dr.GetValue(5).ToString();
                   ud.Gender = dr.GetValue(6).ToString();
                   ud.AccountBalance = dr.GetValue(7).ToString();
               }
               dr.Close();

           }
           finally
           {
               conn.Close();
           }
           return ud;
       }
       public void UpdateAccount(UpdateDetails ud)
       {
           //getDetails();
           SqlConnection con = new SqlConnection();
           try
           {
               con.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
               con.Open();
               string test;
               test = Constant.accountno;

               string getId = Query.selectId + test;
               SqlCommand cmd = new SqlCommand(getId, con);
               SqlDataReader dr = cmd.ExecuteReader();
               if (dr.Read())
               {
                   getId = dr.GetValue(0).ToString();
               }
               dr.Close();
               SqlCommand cmd1 = new SqlCommand("updatedetails", con);
               cmd1.CommandType = CommandType.StoredProcedure;
               cmd1.Parameters.AddWithValue("@AccountNo", test);
               cmd1.Parameters.AddWithValue("@Customername", ud.CustomerName);
               cmd1.Parameters.AddWithValue("@Age", ud.Age);
               cmd1.Parameters.AddWithValue("@Address", ud.Address);
               cmd1.Parameters.AddWithValue("@Emailid", ud.EmailId);
               cmd1.Parameters.AddWithValue("@City", ud.City);
               cmd1.Parameters.AddWithValue("@Gender", ud.Gender);
               cmd1.Parameters.AddWithValue("@AccountBalance", ud.AccountBalance);

               cmd1.ExecuteNonQuery();
           }

           finally
           {
               con.Close();
           }
       }

       public approveLoans approvepageload()
       {
           approveLoans al = new approveLoans();
           SqlConnection con = new SqlConnection();
           try
           {
               con.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
               con.Open();

               string acctno = Constant.accountno;

               string selcetAccount = Query.selectAllViewApprove + acctno;
               SqlCommand cmd = new SqlCommand(selcetAccount, con);
               SqlDataReader dr = cmd.ExecuteReader();
               if (dr.Read())
               {
                   al.AccountNo = dr.GetValue(0).ToString();
                   al.Loans = dr.GetValue(1).ToString();
                   al.LoanAmount = dr.GetValue(2).ToString();
               }
               dr.Close();
           }
           finally
           {
               con.Close();
              
           }
           return al;
       }
        public void approveloans(approveLoans al)
        {
           
            long acct_bal = 0;
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
                con.Open();
                SqlCommand cmd1 = new SqlCommand("approveloans", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@AccountNo", al.AccountNo);
                cmd1.Parameters.AddWithValue("@Loans", al.Loans);
                cmd1.Parameters.AddWithValue("@LoanAmount", al.LoanAmount);
               cmd1.Parameters.AddWithValue("@AccountBalance", acct_bal);
                cmd1.ExecuteNonQuery();
            }

            finally
            {
                con.Close();
            }
        }

        public depositdetails fdpageload()
        {
            depositdetails dd = new depositdetails();
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
                con.Open();
                string acctno = Constant.accountno;
                string selcetAccount = Query.selectfd + acctno;
                SqlCommand cmd = new SqlCommand(selcetAccount, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    
                    dd.DepositAmount = dr.GetValue(0).ToString();

                }
                dr.Close();
            }
            finally
            {
                con.Close();
            }
            return dd;
        }
        public void fdApprove(depositdetails dd)
         {
             SqlConnection con = new SqlConnection();
             try
             {
                 con.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
                 con.Open();
                 SqlCommand cmd1 = new SqlCommand("approvefd", con);
                 cmd1.CommandType = CommandType.StoredProcedure;
                 cmd1.Parameters.AddWithValue("@AccountNo", Constant.accountno);
                 cmd1.Parameters.AddWithValue("@FixedDeposit", dd.DepositAmount);
                 cmd1.ExecuteNonQuery();
                
             }

             finally
             {
                 con.Close();
             }
            
         }
       }
         
        }
        
    

     
