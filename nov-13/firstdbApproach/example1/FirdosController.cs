using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstDbExample2.Models;

namespace FirstDbExample2.Controllers
{
    public class firdosController : Controller
    {
        Database1Entities db = new Database1Entities();
        // GET: firdos
        public ActionResult Index()
        {
            return View(db.Tables);
        }
    }
}