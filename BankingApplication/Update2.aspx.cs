using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.SessionState;
using System.Data;
using System.Configuration;
using BankingApplication.Models;

namespace BankingApplication
{
    public partial class Update2 : System.Web.UI.Page
    {
        Admin ad = new Admin();
        UpdateDetails ud = new UpdateDetails();
        protected void Page_Load(object sender, EventArgs e)
        {
            AccountNoText.Text = Constant.accountno;
            if (!IsPostBack)
            {
                CustomerText.EnableViewState = true;
                AgeText.EnableViewState = true;
                AddressText.EnableViewState = true;
                EmailText.EnableViewState = true;
                CityText.EnableViewState = true;
                GenderText.EnableViewState = true;
                AccntBalText.EnableViewState = true;

                ud = ad.updatepageload();

                AccountNoText.Text = Constant.accountno;
                CustomerText.Text = ud.CustomerName;
                AgeText.Text = ud.Age;
                AddressText.Text = ud.Address;
                EmailText.Text = ud.EmailId;
                CityText.Text = ud.City;
                GenderText.Text = ud.Gender;
                AccntBalText.Text = ud.AccountBalance;
            
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            AccountNoText.Text = Constant.accountno;
            ud.CustomerName = CustomerText.Text;
            ud.Age = AgeText.Text;
            ud.Address = AddressText.Text;
            ud.EmailId = EmailText.Text;
            ud.City = CityText.Text;
            ud.Gender = GenderText.Text;
            ud.AccountBalance = AccntBalText.Text;
            ad.UpdateAccount(ud);
            Response.Write(@"<script language='javascript'>alert('Account has been updated.')</script>");
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


   

