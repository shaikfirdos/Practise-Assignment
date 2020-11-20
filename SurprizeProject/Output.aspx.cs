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
    public partial class Output : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from FlightTable1 Where Source = @source AND Destination=@destination",con);
            cmd.Parameters.AddWithValue("@source", TextBox6.Text);
            cmd.Parameters.AddWithValue("@destination", TextBox7.Text);
            SqlDataReader reader = cmd.ExecuteReader();
           // string Flight_Id, Flight_Name, Flight_Number;
            if(reader.HasRows)
            {
                Response.Write("Ticket has generated  as per details :");
                //reader.Read();
                //Flight_Id = reader[0].ToString();
                //Flight_Number = reader[1].ToString();
                //Flight_Name = reader[2].ToString();
                //reader.Close();
                SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString4"].ConnectionString);
                SqlCommand cmd1 = new SqlCommand("insert into OutputTable1 values(@fid,@fname,@fno,@pname,@age,@gender,@source,@destination)", con1);
                cmd1.Parameters.AddWithValue("@fid", TextBox1.Text);
                cmd1.Parameters.AddWithValue("@fname", TextBox2.Text);
                cmd1.Parameters.AddWithValue("@fno", TextBox3.Text);
                cmd1.Parameters.AddWithValue("@pname",TextBox4.Text);
                cmd1.Parameters.AddWithValue("@age", TextBox5.Text);
                cmd1.Parameters.AddWithValue("@source", TextBox6.Text);
                cmd1.Parameters.AddWithValue("@destination", TextBox7.Text);



                if (RadioButton1.Checked)
                {
                    cmd.Parameters.AddWithValue("@gender", RadioButton1.Text);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@gender", RadioButton2.Text);
                }
                //int affectedrows = cmd.ExecuteNonQuery();
                con.Close();
               

                    Response.Write("<br>FlightId = " +TextBox1.Text);
                    Response.Write("<br>FlightName =" + TextBox2.Text);
                    Response.Write("<br>FlightNumber=" + TextBox3.Text);
                    Response.Write("<br>PassengerName=" + TextBox4.Text);
                    Response.Write("<br>Age=" + TextBox5.Text);
                    Response.Write("<br>Source=" + TextBox6.Text);
                    Response.Write("<br>Destination=" + TextBox7.Text);
               

                




            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("FlightDetails.aspx");
        }
    }
}