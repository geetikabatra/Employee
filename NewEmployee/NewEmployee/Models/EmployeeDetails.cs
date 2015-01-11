using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewEmployee.Models
{
    public class EmployeeDetails
    {
        public Int32 empdet_id { get; set; }
        public Int32 empdet_empId { get; set; }
        public Int32 empdet_FirstName { get; set; }
        public Int32 empdet_MiddleName { get; set; }
        public Int32 empdet_LastName { get; set; }
        public Int32 empdet_CityId { get; set; }
        public Int32 empdet_residentialAddress { get; set; }
        public Int32 empdet_residentialPostCode { get; set; }

        public virtual tbl_city tbl_city { get; set; }
        public virtual tbl_Employee tbl_Employee { get; set; }




    }

}