using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using BankingApplication.Models;
namespace BankingApplication
{
    public partial class Approveloans : System.Web.UI.Page
    {
        Admin ad = new Admin();
        approveLoans al = new approveLoans();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            al=ad.approvepageload();
            AccountNoText.Text = al.AccountNo;
            LoansText.Text = al.Loans;
            LoanAmountText.Text = al.LoanAmount;
        }

        protected void Homebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("admintasks.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            ClientScript.RegisterStartupScript(this.GetType(), "Pop", "openModal();", true);


        }
        protected void approve_click(object sender, EventArgs e)
        {
            ad.approveloans(al);
            Response.Redirect("Admintasks.aspx");
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage.aspx");
        }
       
    }
}


 //protected void Page_Load(object sender, EventArgs e)
 //       {
            
            //SqlConnection con = new SqlConnection();
            //try
            //{
            //    con.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
            //    con.Open();
            //   // string acctno = Request.QueryString[0];
            //    string acctno = Constant.accountno;
            //    TextBox1.Text = acctno;
            //    string selcetAccount = "select * from loansTT where account_no= " + acctno;
            //    SqlCommand cmd = new SqlCommand(selcetAccount, con);
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    if (dr.Read())
            //    {
            //        TextBox1.Text = dr.GetValue(0).ToString();
            //        TextBox9.Text = dr.GetValue(1).ToString();
            //        TextBox11.Text = dr.GetValue(2).ToString();
            //    }
            //    dr.Close();
            //}
            //finally
            //{
            //    con.Close();
            //}
        //}

//protected void Button1_Click(object sender, EventArgs e)
//        {
            //string approve_loans = null, loans = null;
            //long acct_bal = 0;
            //SqlConnection con = new SqlConnection();
            //try
            //{
            //    con.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
            //    con.Open();
            //    SqlCommand cmd1 = new SqlCommand("approveloans", con);
            //    cmd1.CommandType = CommandType.StoredProcedure;
            //    cmd1.Parameters.AddWithValue("@AccountNo", TextBox1.Text);
            //    cmd1.Parameters.AddWithValue("@Loans", TextBox9.Text);
            //    cmd1.Parameters.AddWithValue("@LoanAmount", TextBox11.Text);
            //    cmd1.Parameters.AddWithValue("@AccountBalance", acct_bal);
            //    cmd1.ExecuteNonQuery();

            //    Response.Redirect("<script language='javascript'>alert('Loans have been approved.')</script>");
            //    Response.Redirect("admintasks.aspx");
            //}

            //finally
            //{
            //    con.Close();
            //}
//        protected void Button1_Click(object sender, EventArgs e)
//        {
//            string approve_loans = null, loans = null;
//            long acct_bal = 0;
//            SqlConnection con = new SqlConnection();
//            try
//            {
//                con.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
//                con.Open();
//                string getApprovedLoans = "select account_balance,loans,approved_loans from accountT where account_no= " + TextBox1.Text;

//                SqlCommand cmd = new SqlCommand(getApprovedLoans, con);
//                SqlDataReader dr = cmd.ExecuteReader();

//                if (dr.Read())
//                {
//                    acct_bal = Convert.ToInt64(dr.GetValue(0));
//                    loans = dr.GetValue(1).ToString();
//                    approve_loans = dr.GetValue(2).ToString();
//                }
//                dr.Close();
//                acct_bal = acct_bal + Convert.ToInt64(TextBox11.Text);
//                approve_loans = approve_loans.Replace("no", "yes");
//                string updateAccount = "update accountT set account_balance = '" + acct_bal + "' ,approved_loans='" + approve_loans + "' where account_no='" + TextBox1.Text + "'";
//                SqlCommand cmd1 = new SqlCommand(updateAccount, con);


//                cmd1.ExecuteNonQuery();
//                Response.Write("<script language='javascript'>alert('Loans have been approved.')</script>");
//                Response.Redirect("admintasks.aspx");
//            }

//            //Response.Redirect("Login.aspx");
//            finally
//            {
//                con.Close();
//            }
//        }

//        protected void Button2_Click(object sender, EventArgs e)
//        {
//            Response.Redirect("admintasks.aspx");
//        }
//    }
//}