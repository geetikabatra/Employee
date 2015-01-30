using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeMvc.Models
{
    public class tbl_city
    {
        public int citId { get; set; }
        public string cit_name { get; set; }
        public int cit_couId { get; set; }

        public virtual tbl_Country Country { get; set; }
        public virtual ICollection<tbl_EmployeeDetails> EmployeeDetails { get; set; }
    }
}