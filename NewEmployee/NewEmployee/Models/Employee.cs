using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;



namespace NewEmployee.Models
{
    public class Employee
    {
        [Key] public Int32 emp_Id { get; set; }
        public String emp_Login { get; set; }
        public String emp_Password { get; set; }
        public DateTime emp_CreateDate { get; set; }
        public DateTime emp_LastLogin { get; set; }
        public Boolean emp_IsRemove { get; set; }


        public virtual ICollection<EmployeeDetails> tbl_EmployeeDetails { get; set; }
       

    }
}