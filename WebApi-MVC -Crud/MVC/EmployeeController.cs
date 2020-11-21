using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            IEnumerable<mvcEmployeeModel> empList;//Create an instance
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Employees").Result;//we have to call the getemployee method in webapi project
            empList = response.Content.ReadAsAsync<IEnumerable<mvcEmployeeModel>>().Result;//Its convert the webapi cord to IEnumerable collections
            return View(empList);
        }

        public ActionResult AddOrEdit(int id=0)
        {
            if(id==0)
            return View(new mvcEmployeeModel());  //Edit

            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Employees/" + id.ToString()).Result;//this web api cal will insert new record into employee table and store the call result intoo "response" object
                return View(response.Content.ReadAsAsync<mvcEmployeeModel>().Result);
            }
        }

        [HttpPost]
        public ActionResult AddOrEdit(mvcEmployeeModel emp)//In order to insert operation we need to call http web api post method
        {
            if(emp.EmployeeId==0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Employees", emp).Result;//this web api cal will insert new record into employee table and store the call result intoo "response" object
                TempData["SuccessMessage"] = "Saved Sucessfully";
            }

            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Employees/"+emp.EmployeeId, emp).Result;//this web api cal will insert new record into employee table and store the call result intoo "response" object
                TempData["SuccessMessage"] = "Updated Sucessfully";
              
            }
            return RedirectToAction("Index");

        }
        
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Employees/" + id.ToString()).Result;//this web api cal will insert new record into employee table and store the call result intoo "response" object
            TempData["SuccessMessage"] = "Deleted Sucessfully";
            return RedirectToAction("Index");

        }
    }
}