using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace BankingApplication
{
    public partial class ApplyLoan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string loan = null, account_no=null;
            string userName = Constant.username;
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
                con.Open();
                string getLoan = "select loans, account_no from accountT where customer_name = '" + userName + "'";
                SqlCommand cmd = new SqlCommand(getLoan, con);
                SqlDataReader dr1 = cmd.ExecuteReader();
                if (dr1.Read())
                {
                    loan = dr1.GetValue(0).ToString();
                    account_no = dr1.GetValue(1).ToString();
                }
                dr1.Close();

                if(loan=="" || loan == null)
                {
                    string insertLoans = "insert into loansTT values('" + account_no + "','" + DropDownList1.Text + "','" + TextBox1.Text + "')";
                    SqlCommand cmd2 = new SqlCommand(insertLoans, con);
                    cmd2.ExecuteNonQuery();

                    string updateAccount1 = "update accountT set loans = '" + DropDownList1.Text + "',approved_loans = 'no' where account_no ='" + account_no + "'";
                    SqlCommand cmd1 = new SqlCommand(updateAccount1, con);
                    cmd1.ExecuteNonQuery();
                    Response.Write(@"<script language='javascript'>alert('Applied for loan.')</script>");
                    Constant.username = userName;
                    Response.Redirect("accountsummary.aspx");
                }
                else 
                {
                    Response.Write(@"<script language='javascript'>alert('Customer already applied for loan.')</script>");
                    Constant.username = userName;
                    Response.Redirect("accountsummary.aspx?username =" + userName);
                }
                
                
            }
            finally
            {
                con.Close();
            }
        }

    }
}
