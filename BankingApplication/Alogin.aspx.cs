using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingApplication
{
    public partial class Alogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
       
        {
            SqlConnection con = new SqlConnection();
           
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
                con.Open();
               
                string checkuser = "select * from loginT where id=1";
                SqlCommand cmd = new SqlCommand(checkuser, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string username = dr.GetValue(0).ToString();
                    string password = dr.GetValue(1).ToString();
                    if (UserText.Text == username && PassText.Text == password)
                    {
                       
                        Response.Redirect("Admintasks.aspx");
                    }
                    else
                    {
                        Response.Write("<script language='javascript'>alert('Incorrect Credentials.')</script>");
                    }
                }
            }

            finally
            {
                con.Close();
            }

        }

        protected void btnSubmit0_Click1(object sender, EventArgs e)
        {
            Server.Transfer("Homepage.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage.aspx");
        }
        }
    }
