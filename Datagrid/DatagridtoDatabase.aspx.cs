using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class DatagridDatabase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Establish the database connection
            using (SqlConnection Connect = new SqlConnection("data source=.;database=assignment;integrated security= SSPI"))
            {
                SqlDataAdapter SDA = new SqlDataAdapter("Select * from students",Connect);//to retrive the data from database- student created
                SqlDataAdapter SDA1 = new SqlDataAdapter("Select * from Employee", Connect);//to retrive the data from database- student created
                SqlDataAdapter SDA2 = new SqlDataAdapter("Select * from  CricketTeam", Connect);//to retrive the data from database- student created
                SqlDataAdapter SDA3 = new SqlDataAdapter("Select * from  IRS", Connect);//to retrive the data from database- student created
                SqlDataAdapter SDA4 = new SqlDataAdapter("Select * from  Bank_EmployeeDetails", Connect);//to retrive the data from database- student created
                DataSet ds = new DataSet();//to convert the data into the grid.
                DataSet ds1 = new DataSet();//to convert the data into the grid.
                DataSet ds2 = new DataSet();//to convert the data into the grid.
                DataSet ds3= new DataSet();//to convert the data into the grid.
                DataSet ds4 = new DataSet();//to convert the data into the grid.

                SDA.Fill(ds);
                SDA1.Fill(ds1);
                SDA2.Fill(ds2);
                SDA3.Fill(ds3);
                SDA4.Fill(ds4);

                DataGrid1.DataSource = ds;
                DataGrid1.DataBind();
                DataGrid2.DataSource = ds1;
                DataGrid2.DataBind();
                DataGrid3.DataSource = ds2;
                DataGrid3.DataBind();
                DataGrid4.DataSource = ds3;
                DataGrid4.DataBind();
                DataGrid5.DataSource = ds4;
                DataGrid5.DataBind();
            }
        }
    }
}