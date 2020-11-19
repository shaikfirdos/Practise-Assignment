using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TextBox1.Focus();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "123456" && TextBox2.Text == "admin")
            {
                Response.Write("Login  Successful");

                Response.Redirect("RedirectPage.aspx?Name=" + TextBox1.Text + "&Pwd =" + TextBox2.Text);

            }
            else
                Label1.Text = "Invalid User credential, Login failed";
        }
    }
}