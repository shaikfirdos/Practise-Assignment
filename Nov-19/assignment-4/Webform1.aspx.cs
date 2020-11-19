using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                TextBox1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "Firdos" && TextBox2.Text == "Firdos@123")
            {
                Response.Write("Login  Successful");
                Response.Redirect("HomePage.aspx?Name=" + TextBox1.Text + "&Pwd =" + TextBox2.Text);

            }
            else
                lablstatus.Text = "Invalid User credential, Login failed";
        }
    }
}