using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ONLINEDONATIONSYSTEM
{
    public partial class Donate : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Session["id1"] = Session["userid"] as string;
                string id = Session["userid"] as string;
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand();
                SqlCommand cmd1 = new SqlCommand();
                cmd.CommandText = "idexists";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "checkamount";
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = TextBox1.Text.Trim();

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

                    cmd1.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                    cmd1.Parameters.Add("@amount", SqlDbType.Int);
                    cmd1.Parameters["@amount"].Direction = ParameterDirection.Output;

                    cmd1.Connection = con;
                    cmd1.ExecuteNonQuery();

                    int check1 = Convert.ToInt32(cmd1.Parameters["@amount"].Value);
                    int amount = Convert.ToInt32(TextBox2.Text.Trim());

                    if (check1 >= amount)
                    {
                        Response.Write("<script> alert('sufficient balance') </script>");
                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.CommandText = "checkamount";
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.Add("@id", SqlDbType.VarChar).Value = TextBox1.Text.Trim();
                        cmd2.Parameters.Add("@amount", SqlDbType.Int);
                        cmd2.Parameters["@amount"].Direction = ParameterDirection.Output;

                        cmd2.Connection = con;
                        cmd2.ExecuteNonQuery();
                        int ramt = Convert.ToInt32(cmd2.Parameters["@amount"].Value);

                        int newamt = ramt + amount;
                        SqlCommand cmd3 = new SqlCommand();
                        cmd3.CommandText = "addamt";
                        cmd3.CommandType = CommandType.StoredProcedure;
                        cmd3.Parameters.Add("@id", SqlDbType.VarChar).Value = TextBox1.Text.Trim();
                        cmd3.Parameters.Add("@amount", SqlDbType.Int).Value = newamt;
                        cmd3.Connection = con;
                        cmd3.ExecuteNonQuery();
                        int damt = check1 - amount;

                        SqlCommand cmd4 = new SqlCommand();
                        cmd4.CommandText = "addamt";
                        cmd4.CommandType = CommandType.StoredProcedure;
                        cmd4.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                        cmd4.Parameters.Add("@amount", SqlDbType.Int).Value = damt;
                        cmd4.Connection = con;
                        cmd4.ExecuteNonQuery();
                        SqlCommand cmd5 = new SqlCommand();
                        cmd5.CommandText = "insertvalues";
                        cmd5.CommandType = CommandType.StoredProcedure;
                        cmd5.Parameters.Add("@did", SqlDbType.VarChar).Value = id;
                        cmd5.Parameters.Add("@rid", SqlDbType.VarChar).Value = TextBox1.Text.Trim();
                        cmd5.Parameters.Add("@amt", SqlDbType.Int).Value = amount;
                        cmd5.Connection = con;
                        cmd5.ExecuteNonQuery();
                        using (MailMessage mail = new MailMessage())
                        {
                            mail.From = new MailAddress("aq70992@gmail.com");
                            mail.To.Add("l200968@lhr.nu.edu.pk");
                            mail.To.Add("l200940@lhr.nu.edu.pk");
                            mail.Subject = "Online Donation";
                            mail.Body = "<h1>Donation Sent Successfully</h1>";
                            mail.IsBodyHtml = true;

                            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                            {
                                smtp.Credentials = new System.Net.NetworkCredential("aq70992@gmail.com", "gpokyaotgmzxsglk");
                                smtp.EnableSsl = true;
                                smtp.Send(mail);
                                Label1.Text = "Donation Sent Successfully*";
                            }
                        }
                        Response.Write("<script> alert('sent successfully') </script>");



                    }
                    else if(check1<amount)
                    {
                        Response.Write("<script> alert('insufficient balance ') </script>");
                        Response.Redirect("~/donate.aspx");
                    }

                    //Response.Redirect("admin_home.aspx");
                }
                else
                {
                    Response.Write("<script> alert('User  does not exists') </script>");
                    Response.Redirect("~/donate.aspx");

                }





            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }
       
    }
   
}