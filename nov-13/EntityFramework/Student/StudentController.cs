using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Student.Models;

namespace Student.Controllers
{
    public class Student1Controller : Controller
    {
        Student1Context sb = new Student1Context();
        // GET: Student1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            return View(sb.StudentTable.ToList());
        }
    }
}