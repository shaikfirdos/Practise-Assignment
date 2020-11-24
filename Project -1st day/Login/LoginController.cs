using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserReg.Models;

namespace UserReg.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authorize(UserReg.Models.RegistrationTable123 Fg)//It is for checking
        {
            using (BankEntities db = new BankEntities())
            {
                var checkdetails = db.RegistrationTable123.Where(x => x.AccountHoldername == Fg.AccountHoldername && x.Password == Fg.Password).FirstOrDefault();//And operation
                if(checkdetails!= null)
                
                    Fg.LoginErrorMsg = "Login Successfully.";
                    return View("Login", Fg);
                
                //else
               
                //    Fg.LoginErrorMsg = "Login Successfully.";
                //    return View("Login", Fg);

            }
               
        }
    }
}