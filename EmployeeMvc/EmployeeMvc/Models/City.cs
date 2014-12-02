using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeMvc.Models
{
    public class City
    {
        public int citId { get; set; }
        public string cit_name { get; set; }
        public int cit_couId { get; set; }

        public virtual tbl_Country tbl_Country { get; set; }
        public virtual ICollection<tbl_EmployeeDetails> tbl_EmployeeDetails { get; set; }
    }
}