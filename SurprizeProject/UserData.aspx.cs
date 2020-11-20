using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace PractideProject
{
    public partial class UserData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
            con.Open();
            var InsertQuery = "insert into UserTable1(UserName,Password,ConfirmPassword,Age,Gender) values(@U,@P,@CP,@a,@g)";
            SqlCommand cmd = new SqlCommand(InsertQuery, con);
            cmd.Parameters.AddWithValue("@U", TextBox1.Text);
            cmd.Parameters.AddWithValue("@P", TextBox2.Text);
            cmd.Parameters.AddWithValue("@CP", TextBox3.Text);
            cmd.Parameters.AddWithValue("@a", TextBox4.Text);
            if (Male.Checked)
            {
                cmd.Parameters.AddWithValue("@g", Male.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@g", Female.Text);
            }
            int affectedrows = cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Regitration Sucessfully";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("FlightDetails.aspx");
        }
    }

}
