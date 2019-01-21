using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using System.IO;
using BankingApplication.Models;

namespace BankingApplication
{
    public partial class Viewloans : System.Web.UI.Page
    {

        Admin ad = new Admin();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewLoans();
            }
        }
        private void ViewLoans()
        {
            IList<LoanDetails> details = new List<LoanDetails>();
            details = ad.ListViewLoans();

            IEnumerable<LoanDetails> de = details.OrderBy(p => p.Address).ThenByDescending(p => p.Age).ThenBy(p => p.AccountBalance).ToList();
            de= from p in details
            orderby p.Address, p.Age descending, p.CustomerName
            select p;



            ViewLoansGrid.DataSource = de;
            ViewLoansGrid.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (AdminTasksdroDown.Text == "view loan details")
            {
                ViewLoans();
            }
            else if (AdminTasksdroDown.Text == "Approve Loans")
            {
                Constant.menuVal = AdminTasksdroDown.Text;
                Response.Redirect("Update1.aspx");
            }
            else if (AdminTasksdroDown.Text == "ReviewDoc")
            {
                Constant.menuVal = AdminTasksdroDown.Text;
                Response.Redirect("download.aspx");
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
 
   





