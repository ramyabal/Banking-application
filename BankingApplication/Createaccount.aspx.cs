using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using BankingApplication.Models;

namespace BankingApplication
{
    public partial class Createaccount : System.Web.UI.Page
    {
        Admin ad = new Admin();
        AccountDetails Ad= new AccountDetails();
        protected void Page_Load(object sender, EventArgs e)
        { 
        }
        
        protected void Button2_Click(object sender, EventArgs e)
        {
            Ad.CustomerName = CustomerText.Text;
            Ad.password = passText.Text;
            Ad.Confirmpassword = CpassText.Text;
            Ad.Age = AgeText.Text;
            Ad.Address = AddressText.Text;
            Ad.EmailId = EmailText.Text;
            Ad.City = CityText.Text;
            Ad.Gender = GenderRadioButton.Text;
            Ad.AccountBalance = AcBalText.Text;
            ad.CreateUser(Ad);
            Response.Write(@"<script language='javascript'>alert('Account has been created.')</script>");
        }

        protected void Homebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admintasks.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage.aspx");
        }
    }
}

