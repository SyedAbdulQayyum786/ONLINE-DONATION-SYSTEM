using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ONLINEDONATIONSYSTEM
{
    public partial class usertransactionhistory : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["id2"] = Session["userid"] as string;
            string id = Session["id2"] as string;
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd5 = new SqlCommand();
            cmd5.CommandText = "showhistory";
            cmd5.CommandType = CommandType.StoredProcedure;
            cmd5.Parameters.Add("@id", SqlDbType.VarChar).Value = id;

            cmd5.Connection = con;
            cmd5.ExecuteNonQuery();
            GridView1.DataSource = cmd5.ExecuteReader();
            GridView1.DataBind();
        }
    }
}