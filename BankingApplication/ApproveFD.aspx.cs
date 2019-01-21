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
    public partial class ApproveFD : System.Web.UI.Page
    {
        Admin ad = new Admin();
        depositdetails dd = new depositdetails();
        protected void Page_Load(object sender, EventArgs e)
        {
            dd=ad.fdpageload();
            AccountNoText.Text = Constant.accountno;
            DepositeAmountText.Text = dd.DepositAmount;
           
        }

      protected void Button1_Click(object sender, EventArgs e)
        {
            ad.fdApprove(dd);
            Response.Write("<script language='javascript'>alert('Loans have been approved.')</script>");
        }

      protected void Homebtn_Click(object sender, EventArgs e)
      {
          Response.Redirect("Admintasks.aspx");
      }

      protected void LogoutBtn_Click(object sender, EventArgs e)
      {
          Response.Redirect("Homepage.aspx");
      }

    }
}
 

       