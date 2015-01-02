using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewEmployee.Models
{
    public class tbl_Employee
    {
        public Int32 emp_Id { get; set; }
        public String emp_Login { get; set; }
        public String emp_Password { get; set; }
        public DateTime emp_CreateDate { get; set; }
        public DateTime emp_LastLogin { get; set; }
        public Boolean emp_IsRemove { get; set; }

        public virtual ICollection<tbl_EmployeeDetails> tbl_EmployeeDetails { get; set; }


    }
}