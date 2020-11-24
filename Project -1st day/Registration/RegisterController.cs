using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserRegistration.Models;

namespace UserRegistration.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public ActionResult Register(int id = 0)//get the data from table
        {
            RegistrationTable123 usermodel = new RegistrationTable123();//create instance for Model table
            
            return View(usermodel);//View data in the table
        }
        [HttpPost]
        public ActionResult Register(RegistrationTable123 Rg)
        {

            using (DBModels DB = new DBModels()) //create an instance for table name to adding the data in the table
            {

                DB.RegistrationTable123.Add(Rg);//Add the data in table
                DB.SaveChanges();//save the data
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successfully.";
            return View("Register", new RegistrationTable123());
        }
    }
}