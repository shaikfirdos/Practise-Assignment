using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web1
{
    public partial class Oncommand : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            Label1.Text = "You choose" + e.CommandName + "item" + e.CommandArgument;
        }

        protected void LinkButton2_Command(object sender, CommandEventArgs e)
        {
            Label1.Text = " you choose" + e.CommandName + "item" + e.CommandArgument;
        }
    }
}