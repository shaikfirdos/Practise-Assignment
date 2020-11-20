using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace PractideProject
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from UserTable1 where UserName=@Uname AND Password=@pwd", con);
            cmd.Parameters.AddWithValue("@Uname", TextBox1.Text);
            cmd.Parameters.AddWithValue("@pwd", TextBox2.Text);
            int affectedrows = cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Login Sucessfully";
            Response.Redirect("TicketGeneration.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("FlightDetails.aspx");
        }

        //protected void Button3_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TicketGeneration.aspx");
        //}
    }
}