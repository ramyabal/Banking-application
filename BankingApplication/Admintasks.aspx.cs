using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingApplication
{
    public partial class Admintasks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage.aspx");
        }

        protected void Button6_Click1(object sender, EventArgs e)
        {
            if (AdminTasksDropDown.Text == "Create account")
            {
                Response.Redirect("Createaccount.aspx");
            }
            else if (AdminTasksDropDown.Text == "Update/View account")
            {
                Response.Redirect("Viewupdate.aspx");
            }
            else if (AdminTasksDropDown.Text == "View loan status/Aprrove Loans")
            {
                Response.Redirect("Viewloans.aspx");
            }
            else if (AdminTasksDropDown.Text == "ApproveFD")
            {
                Constant.menuVal = AdminTasksDropDown.Text;
                Response.Redirect("Update1.aspx");
            }
        }
    }
}