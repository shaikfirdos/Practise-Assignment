using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("EmployeeName");
            HttpCookie cookie1 = new HttpCookie("EmployeeId");
            HttpCookie cookie2 = new HttpCookie("EmployeeDesignation");
            HttpCookie cookie3 = new HttpCookie("EmployeeEmail");
            HttpCookie cookie4 = new HttpCookie("EmployeeNumber");

            //Assign value to the created cookie
            cookie.Value = " muntaj";
            cookie1.Value = " 101";
            cookie2.Value = " HR";
            cookie3.Value = " muntaj789@gmail.com";
            cookie4.Value = " 1234567890";


            //add cookie to the response instance
            Response.Cookies.Add(cookie);
            Response.Cookies.Add(cookie1);
            Response.Cookies.Add(cookie2);
            Response.Cookies.Add(cookie3);
            Response.Cookies.Add(cookie4);

            //_____________________________Fetch the Cookie Created______________________//
            var Cookie_Value = Response.Cookies["EmployeeName"].Value;
            var Cookie1_Value = Response.Cookies["EmployeeId"].Value;
            var Cookie2_Value = Response.Cookies["EmployeeDesignation"].Value;
            var Cookie3_Value = Response.Cookies["EmployeeEmail"].Value;
            var Cookie4_Value = Response.Cookies["EmployeeNumber"].Value;

            l1.Text = Cookie_Value + "<br/>";
            Label1.Text = Cookie1_Value + "<br/>";
            Label2.Text = Cookie2_Value + "<br/>";
            Label3.Text = Cookie3_Value + "<br/>";
            Label4.Text = Cookie4_Value + "<br/>";
        }
    }
}