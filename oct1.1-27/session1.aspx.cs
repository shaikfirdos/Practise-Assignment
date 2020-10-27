using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class session1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (TextBox2.Text == "Password" || TextBox2.Text =="HK" || TextBox2.Text =="F!RD05")
            {
                //storing an email to the session
                Session["TextBox1"] = TextBox1.Text;
            }

            if (Session["TextBox1"] != null)
            {
                //Display the stored email
                Label3.Text = "This email is stored in the session";
                Label4.Text = Session["TextBox1"].ToString();
            }

        }
    }
}