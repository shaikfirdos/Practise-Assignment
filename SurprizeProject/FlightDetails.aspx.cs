using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace PractideProject
{
    public partial class FlightDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            var insertquery = "insert into FlightTable1(FlightId,FlightNumber,FlightName,Source,Destination) values(@Id,@number,@name,@source,@destination)";
            SqlCommand cmd = new SqlCommand(insertquery, con);
            cmd.Parameters.AddWithValue("@Id", TextBox1.Text);
            cmd.Parameters.AddWithValue("@number", TextBox2.Text);
            cmd.Parameters.AddWithValue("@name", TextBox3.Text);
            cmd.Parameters.AddWithValue("@source", TextBox4.Text);
            cmd.Parameters.AddWithValue("@destination", TextBox5.Text);
            int affectedrows = cmd.ExecuteNonQuery();
            if (affectedrows > 0)
            {
                Label1.Text = "Flight Details Added Sucessfully!!!";
            }
            else
            {
                Label1.Text = "Check Your Data";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserData.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}
