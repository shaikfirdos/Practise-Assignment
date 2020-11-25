using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistrationPage1.Models;

namespace RegistrationPage1.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Register(int id = 0)//get the data from table
        {
            RegisterTable usermodel = new RegisterTable();//create instance for Model table

            return View(usermodel);//View data in the table
        }
        [HttpPost]
        public ActionResult Register(RegisterTable Rg)
        {

            using (PecuniaBankEntities DB = new PecuniaBankEntities()) //create an instance for table name to adding the data in the table
            {

                DB.RegisterTables.Add(Rg);//Add the data in table
                DB.SaveChanges();//save the data
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successfully.";
            return View("Register", new RegisterTable());
        }
    }
}