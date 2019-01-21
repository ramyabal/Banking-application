using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;  
using System.Web.Services;
using BankingApplication.Models; 
namespace BankingApplication
{
    public partial class ApplyLoa : System.Web.UI.Page
    {
        User ud = new User();
        ApplyLoanDetails ad = new ApplyLoanDetails();
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            ad.AccountNo = Constant.accountno;
            ad.LoansDropdown = loansdropdown.Text;
            ad.LoanAmount = lamount.Text;
            ad.UploadDocuments = Convert.ToString(SaveFile(updoc.PostedFile));
            ad.TypeOfEmployment = Tfemployment.Text;
            ad.IncomePerMonth = Ipmonth.Text;
            ad.UploadPayslips = Convert.ToString(SaveFile(pslips.PostedFile));
            ad.UploadImage = Convert.ToString(SaveFile(pslips.PostedFile));
            ad.city = cityname.Text;
            ad.LoanApplyDate = ApplyDateText.Text;
            ViewUsers1();
            Response.Write("<script language='javascript'>alert('Loan successfully applied.')</script>");
        }
           
            string SaveFile(HttpPostedFile file)
    {
        // Specify the path to save the uploaded file to.
        string savePath = "~\\Files\\";

        // Get the name of the file to upload.
        string fileName = file.FileName;    // must be declared in the class above

        // Create the path and file name to check for duplicates.
        string pathToCheck = savePath + fileName;

        // Create a temporary file name to use for checking duplicates.
        string tempfileName = "";

        // Check to see if a file already exists with the
        // same name as the file to upload.
        if (System.IO.File.Exists(Server.MapPath(pathToCheck)))
        {
            int counter = 2;
            while (System.IO.File.Exists(Server.MapPath(pathToCheck)))
            {
                // if a file with this name already exists,
                // prefix the filename with a number.
                tempfileName = counter.ToString() + fileName;
                pathToCheck = savePath + tempfileName;
                counter++;
            }

            fileName = tempfileName;

            // Notify the user that the file name was changed.
        }


        // Append the name of the file to upload to the path.
        savePath += fileName;

        // Call the SaveAs method to save the uploaded
        // file to the specified directory.
        file.SaveAs(Server.MapPath(savePath));
        return savePath;
    }


            protected void Button1_Click1(object sender, EventArgs e)
            {
                Response.Redirect("Homepage.aspx");
            }
            private void ViewUsers1()
            {
                ud.ApplyLoans(ad);
            }

            protected void Homebtn_Click(object sender, EventArgs e)
            {
                Response.Redirect("Accountsummary.aspx");
            }

            protected void LogoutBtn_Click(object sender, EventArgs e)
            {
                Response.Redirect("Homepage.aspx");
            }
           
        }
    }








