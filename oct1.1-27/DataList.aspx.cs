using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication1
{
    public partial class assignment3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable Table = new DataTable();//created an instance
            Table.Columns.Add("FirstName :");
            Table.Columns.Add("LastName :");
            Table.Columns.Add("Designation :");
            Table.Columns.Add("Location :");
            Table.Columns.Add("Country :");

            Table.Rows.Add("Shaik","Firdos","TechnicalLead","Hyderabad", " India");
            Table.Rows.Add("Bandaru", "Bharagavi", "HR", "Chennai", " India");
            Table.Rows.Add("Syed", "Nayima", "IT Head", "Mumbai", " India");
            Table.Rows.Add("Sarvasiddi", "Ramya", "Manager", "kolkata", " India");
            Table.Rows.Add("Moka", "Sailakshmi", "Sales", "Vizag", " India");
            Table.Rows.Add("Damini", "Priya", "ExecutiveOfficer", "Hyderabad", " India");
            Table.Rows.Add("Bandaru", "Vamsi", "OperatingOfficer", "Karanataka", " India");
            Table.Rows.Add("Priya", "Chowday", "FinancialOfficer", "Bangalore", " India");
            Table.Rows.Add("Sudanshu", "Sharma", "MarketingOfficer", "Noida", " India");
            Table.Rows.Add("Rahul", "Sharma", "CEO", "Chennai", " India");

            DataList1.DataSource = Table;
            DataList1.DataBind();







        }
    }
}