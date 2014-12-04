using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeMvc.Models
{
    public class Employee
    {

        public int emp_Id { get; set; }
        public string emp_Login { get; set; }
        public string emp_Password { get; set;}
        public DateTime emp_CreateDate {get;set;}
        public DateTime emp_LastLogin{get;set ;}
        public Boolean emp_IsRemove { get; set;}

        public virtual ICollection<tbl_EmployeeDetails> EmployeeDetails { get; set;}
    }
    
}