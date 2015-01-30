using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeMvc.Models
{
    public class tbl_EmployeeDetails
    {
        public int empdet_id { get; set; }
        public int empdet_empId { get; set; }
        public string empdet_FirstName { get; set; }
        public string empdet_MiddleName { get; set; }
        public string empdet_LastName { get; set; }
        public int empdet_cityId { get; set; }
        public string empdet_residentialAddress { get; set; }
        public string empdet_residentialPostCode { get; set; }

        public virtual tbl_city city{ get;set;}
        public virtual tbl_Employee Employee { get; set; }
    }
}