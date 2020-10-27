using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class cookiecollection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Setting Expiring Date and Time of the  Cookie
            Response.Cookies["Computer"].Expires = DateTime.Now.AddDays(-1);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "";

            //_____________________Adding Cookies_______________________//

            if(CheckBox1.Checked)
            {
                Response.Cookies["Computer"]["CheckBox1"] = "You have Checked for Iphone And Cookie Triggered "+ "<br/>";
               
            }
            if(CheckBox2.Checked)
            {
                Response.Cookies["Computer"]["CheckBox2"] = "You have Checked for OnePlus And Cookie Triggered" + "<br/>";

            }
            if(CheckBox3.Checked)
            {
                Response.Cookies["Computer"]["CheckBox3"] = "You have Checked for Samsung And Cookie Triggered" + "<br/>";

            }
            if(CheckBox4.Checked)
            {
                Response.Cookies["Computer"]["CheckBox4"] = "You have Checked for Nokia And Cookie Triggered" + "<br/>";

            }
            if(CheckBox5.Checked)
            {
                Response.Cookies["Computer"]["CheckBox5"] = "You have Checked for MI And Cookie Triggered" + "<br/>";
            }
            if (CheckBox6.Checked)
            {
                Response.Cookies["Computer"]["CheckBox6"] = "You have Checked for Oppo And Cookie Triggered" + "<br/>";
            }
            if (CheckBox7.Checked)
            {
                Response.Cookies["Computer"]["CheckBox7"] = "You have Checked for Vivo And Cookie Triggered" + "<br/>";
            }
            if (CheckBox8.Checked)
            {
                Response.Cookies["Computer"]["CheckBox8"] = "You have Checked for Motrolla And Cookie Triggered" + " <br/>";
            }
            if (CheckBox9.Checked)
            {
                Response.Cookies["Computer"]["CheckBox9"] = "You have Checked for Realme And Cookie Triggered " + "<br/>";
            }
            if (CheckBox10.Checked)
            {
                Response.Cookies["Computer"]["CheckBox10"] = "You have Checked for Poco M2 And Cookie Triggered" + "<br/>";
            }
            //________________________fetching cookie________________________//
            if (Request.Cookies["Computer"].Values.ToString()!=null)
            {
                if (Request.Cookies["Computer"]["CheckBox1"]!=null)
                {
                    Label2.Text = Label2.Text + Response.Cookies["Computer"]["CheckBox1"] + " " + " ";
                }
                if (Request.Cookies["Computer"]["CheckBox2"] != null)
                {
                    Label2.Text = Label2.Text + Response.Cookies["Computer"]["CheckBox2"] + " " + " ";
                }
                if (Request.Cookies["Computer"]["CheckBox3"] != null)
                {
                    Label2.Text = Label2.Text + Response.Cookies["Computer"]["CheckBox3"] + " " + " ";
                }
                if (Request.Cookies["Computer"]["CheckBox4"] != null)
                {
                    Label2.Text = Label2.Text + Response.Cookies["Computer"]["CheckBox4"] + " " + " ";
                }
                if (Request.Cookies["Computer"]["CheckBox5"] != null)
                {
                    Label2.Text = Label2.Text + Response.Cookies["Computer"]["CheckBox5"] + " " + " ";
                }
                if (Request.Cookies["Computer"]["CheckBox6"] != null)
                {
                    Label2.Text = Label2.Text + Response.Cookies["Computer"]["CheckBox6"] + " " + " ";
                }
                if (Request.Cookies["Computer"]["CheckBox7"] != null)
                {
                    Label2.Text = Label2.Text + Response.Cookies["Computer"]["CheckBox7"] + " " + " ";
                }
                if (Request.Cookies["Computer"]["CheckBox8"] != null)
                {
                    Label2.Text = Label2.Text + Response.Cookies["Computer"]["CheckBox8"] + " " + " ";
                }
                if (Request.Cookies["Computer"]["CheckBox9"] != null)
                {
                    Label2.Text = Label2.Text + Response.Cookies["Computer"]["CheckBox9"] + " " + " ";
                }
                if (Request.Cookies["Computer"]["CheckBox10"] != null)
                {
                    Label2.Text = Label2.Text + Response.Cookies["Computer"]["CheckBox10"] + " " + " ";
                }
                
            }

            else
            {
                Label2.Text = "Pleasee slect your choice";
                Response.Cookies["Comuter"].Expires = DateTime.Now.AddDays(-1);
            }
        }
    }
}