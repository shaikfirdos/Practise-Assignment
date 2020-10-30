using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace signup1
{
    public partial class Form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var data = "Registration Successfully";
            Response.Write(data);
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);//[Database_name]
            con.Open();
            var insertquery = "insert into REGISTRATIONTABLE1(UserName,EmailAddress,Password,ConfirmPassword,Gender,City) values (@U,@E,@P,@CP,@G,@C)";
            SqlCommand cmd = new SqlCommand(insertquery, con);
            cmd.Parameters.AddWithValue("@U", TextBox1.Text);
            cmd.Parameters.AddWithValue("@E", TextBox2.Text);
            cmd.Parameters.AddWithValue("@P", TextBox3.Text);
            cmd.Parameters.AddWithValue("@CP", TextBox4.Text);
           if(RadioButton1.Checked)
            {
                cmd.Parameters.AddWithValue("@G",RadioButton1.Text);
            }
           else
            {
                cmd.Parameters.AddWithValue("@G", RadioButton2.Text);
            }
            cmd.Parameters.AddWithValue("@C",DropDownList1.SelectedItem.Text);
            int affectedrows = cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("ADMIN.aspx");





        }
    }
}