using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using System.Web.SessionState;
using System.Configuration;

namespace BankingApplication
{
    public partial class Accountsummary : System.Web.UI.Page
    {
        User ud = new User();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            ud.PageLoad();
        }
           

        protected void Button1_Click1(object sender, EventArgs e)
        {

            if (CustomerTasksDropDown.Text == "Account Summary")
            {
                ViewUsers();
                
            }
            else if (CustomerTasksDropDown.Text == "Transfer")
            {
                Response.Redirect("Transfer.aspx");
            }
            else if (CustomerTasksDropDown.Text == "Apply Loan")
            {
               
                Response.Redirect("ApplyLoa.aspx");
            }
            else if (CustomerTasksDropDown.Text == "Apply FD")
            {
               
                Response.Redirect("ApplyFD.aspx");
            }

        }

        private void ViewUsers()
        {
            CustomerDetailsGrid.DataSource = ud.ButtonClick(Constant.username);
            CustomerDetailsGrid.DataBind();
        }

        protected void HomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage.aspx");
        }

        

       
    }
}

            
