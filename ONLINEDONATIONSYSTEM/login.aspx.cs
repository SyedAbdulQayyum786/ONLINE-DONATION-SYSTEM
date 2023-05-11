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
    public partial class login : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "userlogin";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = TextBox1.Text.Trim();
                cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBox2.Text.Trim();

                cmd.Parameters.Add("@output", SqlDbType.Int);
                cmd.Parameters["@output"].Direction = ParameterDirection.Output;
                //var returnParameter = cmd.Parameters.Add("@out", SqlDbType.Int);
                //returnParameter.Direction = ParameterDirection.ReturnValue;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();




                int check = Convert.ToInt32(cmd.Parameters["@output"].Value);

                //Response.Write("<script> alert('"+check+"')</Script>");
                if (check == 1)
                {
                    Response.Write("<script> alert('User Exists') </script>");
                    Session["id"] = TextBox1.Text.Trim();
                    Response.Redirect("~/afteruserlogin.aspx");
                }
                else
                {
                    Response.Write("<script> alert('User  does not exists') </script>");
                    // Response.Redirect("admin-login.aspx");

                }
                con.Close();

            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
           
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }
    }
}