using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hiddenfields1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int count;
        protected void Page_Load(object sender, EventArgs e)
        {

            hdnfldCurrentDateTime.Value = DateTime.Now.ToString();
            firdos.Text = Convert.ToString(hdnfldCurrentDateTime.Value);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            count = int.Parse(HiddenField1.Value);//Hiddenfield by default it gives a string value,int.parse is used to convert the string into integer
            count += 1;
            Response.Write("Number of Clicks on the button are" + count);
            HiddenField1.Value = count.ToString();//Cnverted into string
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HiddenField2.Value = "Hemakumar";
            l1.Text = HiddenField2.Value;
        }
    }
}