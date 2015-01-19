using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace NewEmployee.Models
{
    
    public partial class EmployeeDetails
    {
        public int empdet_id { get; set; }
        public int empdet_empId { get; set; }
        public string empdet_FirstName { get; set; }
        public string empdet_MiddleName { get; set; }
        public string empdet_LastName { get; set; }
        public int empdet_CityId { get; set; }
        public string empdet_residentialAddress { get; set; }
        public string empdet_residentialPostCode { get; set; }

        public virtual City tbl_city { get; set; }
        public virtual Employee tbl_Employee { get; set; }
    }
}
