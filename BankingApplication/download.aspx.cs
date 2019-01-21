using BankingApplication.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace BankingApplication
{
    public partial class download : System.Web.UI.Page
    {
        Admin ad = new Admin();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetLoans();
            }
        }
        private void GetLoans()
        {
            IList<FileUploadDetails> details = new List<FileUploadDetails>();
            details = ad.ListGetLoans();

            FileDwnGrid.DataSource = details;
            FileDwnGrid.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.Text == "ReviewDoc")
            {
                GetLoans();
            }
            else if (DropDownList1.Text == "Approve Loans")
            {
                Response.Redirect("Update1.aspx?LoansButton=" + DropDownList1.Text);
            }
            else if (DropDownList1.Text == "Home")
            {
                Response.Redirect("Admintasks.aspx");
            }
        }


        protected void lnkDownload_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = (sender as LinkButton).CommandArgument;
                Response.ContentType = ContentType;
                Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(filePath.Substring(0)));
                Response.WriteFile(filePath);
                Response.End();
            }
            finally
            {

            }
        }
        protected void btnOpen_Click(object sender, EventArgs e)
        {
            string filePath = (sender as LinkButton).CommandArgument;
            Response.ContentType = "Application/pdf";
            //Get the physical path to the file.
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(filePath));
            // Write the file directly to the HTTP content output stream.
            Response.Redirect(filePath);
            Response.End();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            IList<FileUploadDetails> details = new List<FileUploadDetails>();
            details = ad.ListGetLoans(TxtIndate.Text,txtOutDate.Text);

            FileDwnGrid.DataSource = details;
            FileDwnGrid.DataBind();

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







