using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string connectionString = @"Data Source=HDDRAMYABAL\SQLEXPRESS;Initial Catalog=banking sys;User Id=sa;password=1234qwer$";
                string sql = "select * from debut";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "debut");


                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string s = dt.Rows[i]["programid"].ToString();
                    int index = s.IndexOfAny(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
                    int num = Int32.Parse(s.Substring(index));
                    dt.Rows[i]["programid"] = num.ToString();
                } 
                pac.DataSource = dt;
                pac.DataBind();
            }  
        }
    }
}