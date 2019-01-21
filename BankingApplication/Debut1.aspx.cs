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
    public partial class Debut1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
    }
}
