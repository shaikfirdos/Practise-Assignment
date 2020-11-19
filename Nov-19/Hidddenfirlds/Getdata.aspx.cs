using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hiddenfields1
{
    public partial class Getdata : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string value = Request.Form["HiddenField1"];
            Response.Write("Your Current hit Count is :" + value);
        }
    }
}