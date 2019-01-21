using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace BankingApplication
{
    public partial class update1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string updateButtonId = null;
            Constant.accountno = AccountNoText.Text;
            try
            {
                updateButtonId = Constant.menuVal;
            }
            catch (Exception ex) { }


            if (updateButtonId == "Update Account Details")
            {
                  Response.Redirect("Update2.aspx");
            }

            string loansButtonId = "";
            
            try
            {
                loansButtonId = Constant.menuVal;
            }
            catch (Exception ex) { }
            
            if (loansButtonId == "Approve Loans")
            {
                Response.Redirect("approveloans.aspx");
            }

            string depositButtonId = "";
            
            try
            {
                depositButtonId = Constant.menuVal;
            }
            catch (Exception ex)  { }

            if (depositButtonId == "ApproveFD")
            {
               
                Response.Redirect("approvefd.aspx");
             }
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