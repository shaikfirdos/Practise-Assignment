using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDPROJECT.Context;
using System.Data.Entity;


namespace CRUDPROJECT.Controllers
{
    public class IdiotController : Controller
    {
        // GET: Idiot
        Student1Entities obj1 = new Student1Entities();
        public ActionResult Student(StudentTable123 std)//Its acts as receiver
        {
            //if (std != null)
            //    return View(std);
            //else
            //return View();
            return View(std);
        }

        [HttpPost]
        public ActionResult AddStudent(StudentTable123 model)//the "model" is used for receive the data from view(UI)
        {
            StudentTable123 std = new StudentTable123();//this object is used for receive the data from model

            if (ModelState.IsValid)
            {
                std.Id = model.Id;
                std.Fname = model.Fname;//Its stores the data with respective fields
                std.Lname = model.Lname;
                std.Email = model.Email;
                std.Mobile = model.Mobile;
                std.Description = model.Description;

                if(model.Id==0)
                {
                    obj1.StudentTable123.Add(std);
                    obj1.SaveChanges();
                }
                else
                {
                    obj1.Entry(std).State = EntityState.Modified;
                    obj1.SaveChanges();
                }
            }
            ModelState.Clear();
            
            return View("Student");
        }

        public ActionResult StudentList()
        {
            var store = obj1.StudentTable123.ToList();//It assign the data , which is present at the object.table

            return View(store);
        }

        public ActionResult Delete(int id)
        {
            var store =obj1.StudentTable123.Where(x => x.Id == id).First();
            obj1.StudentTable123.Remove(store);
            obj1.SaveChanges();
            var list = obj1.StudentTable123.ToList();
            return View("StudentList",list);
        }
    }
}