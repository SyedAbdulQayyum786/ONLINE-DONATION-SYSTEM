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
    public partial class afteruserlogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["userid"] = Session["id"] as string;
            string id = Session["userid"] as string;
            TextBox1.Text = id;
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "nameandamount";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id", SqlDbType.Char).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 50);
            cmd.Parameters["@name"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@amount", SqlDbType.Int);
            cmd.Parameters["@amount"].Direction = ParameterDirection.Output;
            //var returnParameter = cmd.Parameters.Add("@out", SqlDbType.Int);
            //returnParameter.Direction = ParameterDirection.ReturnValue;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            TextBox2.Text = Convert.ToString(cmd.Parameters["@name"].Value);
            TextBox3.Text = Convert.ToString(cmd.Parameters["@amount"].Value);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["userid"] = Session["id"] as string;
            string id = Session["userid"] as string;
            Response.Redirect("~/Donate.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["userid"] = Session["id"] as string;
            string id = Session["userid"] as string;
            Response.Redirect("~/usertransactionhistory.aspx");
        }
    }
}