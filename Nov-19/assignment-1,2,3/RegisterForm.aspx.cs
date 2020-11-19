using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                TextBox1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "Firdos" && TextBox2.Text == "Shaik")
            {
                Response.Write("Login  Successful");

                Response.Redirect("Nextpage.aspx?Fname=" + TextBox1.Text + "&Lname =" + TextBox2.Text);

            }
            else if (TextBox1.Text == "Hemakumar" && TextBox2.Text == "Mallavarapu")
            {
                Response.Write("Login  Successful");

                Response.Redirect("Nextpage.aspx?Fname=" + TextBox1.Text + "&Lname =" + TextBox2.Text);

            }
            else if (TextBox1.Text == "BHargavi" && TextBox2.Text == "Bandaru")
            {
                Response.Write("Login  Successful");

                Response.Redirect("Nextpage.aspx?Fname=" + TextBox1.Text + "&Lname =" + TextBox2.Text);

            }
            else
                L2.Text = "Invalid User credential, Login failed";
        }
    }
    }
