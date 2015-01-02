using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewEmployee.Models
{
    public class tbl_city
    {
        public int cit_Id { get; set; }
        public string cit_name { get; set; }
        public int cit_couId { get; set; }

        public virtual tbl_Country tbl_Country { get; set; }
        public virtual ICollection<tbl_EmployeeDetails> tbl_EmployeeDetails { get; set; }
    }
}