using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ONLINEDONATIONSYSTEM
{

    public partial class signup : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
           con.Open();
            string sql = "insert into systemuser values(" + "'" + TextBox1.Text + "'" + "," + "'" + TextBox2.Text + "'" + "," + "'" + TextBox3.Text + "'" + "," + "'" + TextBox4.Text + "'" + "," + "'" + TextBox5.Text + "'" + "," + TextBox6.Text + ")";
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.Connection = con;
           int i= cmd.ExecuteNonQuery();
            if(i==1)
            {
                Response.Redirect("login.aspx");
            }



        }   
    }
}