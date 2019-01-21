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
    public partial class ApplyFD : System.Web.UI.Page
    {
        User ud = new User();
        depositdetails dd = new depositdetails();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            dd.AccountNo = Constant.accountno;
            dd.DepositAmount = AmountText.Text;
            ViewUsers1();
            Response.Write(@"<script language='javascript'>alert('Applied for fixed deposit.')</script>");
        }
        private void ViewUsers1()
        {
            ud.ApplyFd(dd);
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

