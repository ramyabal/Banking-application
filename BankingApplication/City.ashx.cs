using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace BankingApplication
{
    /// <summary>
    /// Summary description for City
    /// </summary>
    public class City : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string term = context.Request["term"] ?? "";
            List<string> ListCityNames = new List<string>();

            string cs = ConfigurationManager.ConnectionStrings["Bankingsysconn"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetCity", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@term",
                    Value = term
                });
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ListCityNames.Add(rdr["City"].ToString());
                }
            }
            JavaScriptSerializer js = new JavaScriptSerializer();
            context.Response.Write(js.Serialize(ListCityNames));

        }


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}