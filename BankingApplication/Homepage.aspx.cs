using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingApplication
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList2.Text == "Admin")
            {
                Response.Redirect("Alogin.aspx");
            }
            else if (DropDownList2.Text == "Customer")
            {
                Response.Redirect("Customerlogin.aspx");
            }
        }
    }
}