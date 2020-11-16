using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandleErrorMVC.Controllers
{
    
    public class HomeController : Controller
    {
        
        
        // GET: Home
        public ActionResult Index()
        {
           
           throw new Exception("This is exception");
          
        }

        public ActionResult About()
        {
            throw new Exception("This is exception");
        }
       

    }
}