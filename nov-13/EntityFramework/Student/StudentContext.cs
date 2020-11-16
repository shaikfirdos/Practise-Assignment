using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Student.Models
{
    public class Student1Context:DbContext
    {
        public Student1Context() : base("StudentConnection")
        {

        }
        public DbSet<Student1> StudentTable { get; set; }
    }
}