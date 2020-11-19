using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Nextpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString["Fname"];
            Response.Write("Hello" + " " + name + " " + ",Welcome to our site");
            Image1.ImageUrl ="h1.gif" ;
        }
    }
}