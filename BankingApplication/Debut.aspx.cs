using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingApplication
{
    public partial class debut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
                BindGrid();
        }  
    private void BindGrid()  
    {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
                con.Open();

                string getDetails = "select *from debut";
                SqlCommand cmd1 = new SqlCommand(getDetails, con);
                SqlDataReader dr1 = cmd1.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[9] {new DataColumn("Production Company", typeof(string)),
                   
                     new DataColumn("PAC ID",typeof(double)),
                     new DataColumn("Program ID",typeof(string)),
                     new DataColumn("PAC Titile",typeof(string)),
                     new DataColumn("Network",typeof(string)),
                     new DataColumn("PAC Type",typeof(string)),
                     new DataColumn("Tax Credit",typeof(string)),
                     new DataColumn("TA Required",typeof(string)),
                     new DataColumn("TA Status",typeof(string))});
                while (dr1.Read())
                {
                    dt.Rows.Add(dr1.GetValue(0), dr1.GetValue(1), dr1.GetValue(2), dr1.GetValue(3), dr1.GetValue(4), dr1.GetValue(5), dr1.GetValue(6), dr1.GetValue(7), dr1.GetValue(8));
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                dr1.Close();
            }
            finally
            {
                con.Close();
            }
        }


    protected void DeleteRecord(int pacid)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=HDDRAMYABAL\SQLEXPRESS;Initial Catalog=banking sys;User Id=sa;password=1234qwer$";
        con.Open();
        SqlCommand com = new SqlCommand("delete from debut where pacid=" + pacid, con);
        com.ExecuteNonQuery();
        con.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                CheckBox chkdel = (CheckBox)row.FindControl("chkSelect"); 
                if (chkdel.Checked)
                {
                    int pacid = Convert.ToInt32(row.Cells[2].Text);
                    DeleteRecord(pacid);
                }
            }
            BindGrid();
        }
    }
}
        
