using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employee.Models
{
    [Table("EmployeeTable1")]
    public class EmployeeM1
    {
        [Key]
        public int Empid { get; set; }
        public string EmpName { get; set; }
        public string EmpDesignation { get; set; }
        public int EmpAge { get; set; }
        public string EmpLocation { get; set; }
    }
}