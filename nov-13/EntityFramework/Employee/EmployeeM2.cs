using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Employee.Models
{
    
    public class EmployeeM2Context : DbContext
    {
        public EmployeeM2Context() : base("EmployeeConnection")
        {

        }
        public DbSet<EmployeeM1> EmployeeTable { get; set; }
    }
}