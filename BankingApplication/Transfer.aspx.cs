using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using BankingApplication.Models;

namespace BankingApplication
{
    public partial class Transfer : System.Web.UI.Page
    {
        User ud = new User();
        TransactionDetails td = new TransactionDetails();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FromAccountText.Text = Constant.accountno;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            td.FromAccountno = FromAccountText.Text;
            td.ToAccountNo = ToAccountText.Text;
            td.Amount = AmountText.Text;
            ViewUsers1();
            
           
            Response.Write("<script>alert('Transfer Successfully.')</script>");
        }
        private void ViewUsers1()
        {
            ud.TransferButtonClick(td);
        }

        protected void Homebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Accountsummary.aspx");
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage.aspx");
        }
        
    }
}


