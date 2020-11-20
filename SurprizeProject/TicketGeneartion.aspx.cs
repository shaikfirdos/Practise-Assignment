using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace PractideProject
{
    public partial class TicketGeneration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString3"].ConnectionString);
            con.Open();
            var InsertQuery = "insert into TicketTable1(PassengerName,Age,Gender,PassengerClassTickets,Source,Destination) values(@P,@A,@G,@PCT,@S,@D)";
            SqlCommand cmd = new SqlCommand(InsertQuery, con);
            cmd.Parameters.AddWithValue("@P", TextBox1.Text);
            cmd.Parameters.AddWithValue("@A", TextBox2.Text);
            if (RadioButton1.Checked)
            {
                cmd.Parameters.AddWithValue("@g", RadioButton1.Text);
            }
            else
            {
                cmd.Parameters.AddWithValue("@g", RadioButton2.Text);
            }
            //if(RadioButtonList1.SelectedValue== "General Class")
            //{
            //    cmd.Parameters.AddWithValue("@PCT", RadioButtonList1);
            //}
            //else if(RadioButtonList1.SelectedValue == "Economy Class")
            //{
            //    cmd.Parameters.AddWithValue("@PCT", RadioButtonList1);
            //}
            //else
            //{
            //    cmd.Parameters.AddWithValue("@PCT", RadioButtonList1);
            //}
            if (RadioButtonList1.SelectedIndex > -1)
            {
                cmd.Parameters.AddWithValue("@PCT",RadioButtonList1.SelectedItem.Text);
            }

            cmd.Parameters.AddWithValue("@S", TextBox3.Text);
            cmd.Parameters.AddWithValue("@D", TextBox4.Text);

            int affectedrows = cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Ticket Generation Sucessfully";
            Response.Redirect("Output.aspx");

        }
    }
}