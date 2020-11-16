using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Firstdb.Models;

namespace Firstdb.Controllers
{
    public class DBfirstApproachController : Controller
    {
        Database1Entities db = new Database1Entities();
        // GET: DBfirstApproach
        public ActionResult Index()
        {
            return View(db.Table1);
        }
    }
}