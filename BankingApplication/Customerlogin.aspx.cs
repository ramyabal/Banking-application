using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace BankingApplication
{
    public partial class Customerlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
                con.Open();

                string uname = UserText.Text;
                string pswd = PassText.Text;
                string checkuser = "select * from loginT where isAdmin='no'";

                SqlCommand cmd = new SqlCommand(checkuser, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string username = dr.GetValue(0).ToString();
                    Constant.username = username;
                    string password = dr.GetValue(1).ToString();
                    if (UserText.Text == username && PassText.Text == password)
                    {
                        Constant.username = UserText.Text;
                        Response.Redirect("accountsummary.aspx");
                    }
                   
                }
                else
                {
                    Response.Write("<script language='javascript'>alert('Incorrect Credentials.')</script>");
                }
            }


            finally
            {
                con.Close();
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage.aspx");
        }

       
    }
}