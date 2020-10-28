using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            Label8.Text = "Hello" + " " + TextBox1.Text + " " + "GoodAfternon!!!!" + "<br/>";
            Label9.Text = "Hello" + " " + TextBox1.Text + " " + "You have Successfully Registerd with the following details" + "<br/>";
            Label10.Text = "UserName : " + TextBox1.Text + "<br/>";
            Label11.Text = "EmailAddress : " + TextBox4.Text + "<br/>";
            if (rd1.Checked)
            {
                Label7.Text = "Gender: " + rd1.Text + "<br/>";
            }
            else 

            {
                Label7.Text = "Gender: " + rd2.Text + "<br/>";
            }

            var data1 = "";
            if (CheckBox1.Checked)
            {
                data1 = CheckBox1.Text;
            }
            if (CheckBox2.Checked)
            {
                data1 = CheckBox2.Text;
            }
            if (CheckBox3.Checked)
            {
                data1 = CheckBox3.Text;
            }
            if (CheckBox4.Checked)
            {
                data1 = CheckBox4.Text;
            }

            ShowCourse.Text = "You have Selected " +  data1 + "<br/>";


            rd1.Checked = false;
            rd2.Checked = false;
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
            CheckBox4.Checked = false;
        }

    }
}
