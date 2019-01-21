using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using BankingApplication.Models;


namespace BankingApplication
{
    public partial class Viewupdate : System.Web.UI.Page
    {
        Admin ad = new Admin();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewUsers();
            }
        }
        private void ViewUsers()
        {
            IList<GetAccountDetails> details = new List<GetAccountDetails>();
            details = ad.ListViewUsers();

            IList<GetAccountDetails> de= details.Where(a => a.CustomerName == "ramya").ToList();
            var ga= from a in details
                      orderby a.Age ascending
                      select a;

            ViewUsersGrid.DataSource = ga;
            ViewUsersGrid.DataBind();
        }
         protected void Button1_Click1(object sender, EventArgs e)
        {
            if (AdminTasksDropDown.Text == "View Account Details")
            {
                ViewUsers();
            }
            else if (AdminTasksDropDown.Text == "Update Account Details")
            {
                Constant.menuVal = AdminTasksDropDown.Text;
                Response.Redirect("Update1.aspx" );
            }
            //else if (AdminTasksDropDown.Text == "Home")
            //{
            //    Response.Redirect("Admintasks.aspx");
            //}
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

    