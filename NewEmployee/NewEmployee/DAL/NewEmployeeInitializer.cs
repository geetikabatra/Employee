using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NewEmployee.Models;


namespace NewEmployee.DAL
{
    public class NewEmployeeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<NewEmployeeContext>
    {
        protected override void Seed(NewEmployeeContext context)
        {
            var Employees = new List<tbl_Employee>
            {
            new tbl_Employee{emp_Login="Carson",emp_Password="Alexander",emp_CreateDate=DateTime.Parse("2005-09-01"),emp_LastLogin=DateTime.Parse("2005-09-01"),emp_IsRemove=false},
            new tbl_Employee{emp_Login="Naruto",emp_Password="Alex",emp_CreateDate=DateTime.Parse("2005-09-01"),emp_LastLogin=DateTime.Parse("2005-09-01"),emp_IsRemove=false},
            new tbl_Employee{emp_Login="Geetika",emp_Password="saibabaji",emp_CreateDate=DateTime.Parse("2005-09-01"),emp_LastLogin=DateTime.Parse("2005-09-01"),emp_IsRemove=false},
            };
            Employees.ForEach(s => context.tbl_Employee.Add(s));
            context.SaveChanges();

            var EmployeeDetail = new List<tbl_EmployeeDetails>
            {
            new tbl_EmployeeDetails{empdet_empId=1,empdet_FirstName="Geetika",empdet_MiddleName="",empdet_LastName="Batra",empdet_CityId=2,empdet_residentialAddress="22,Global Street",empdet_residentialPostCode="121",},
            new tbl_EmployeeDetails{empdet_empId=1,empdet_FirstName="Jay",empdet_MiddleName="",empdet_LastName="Batra",empdet_CityId=2,empdet_residentialAddress="22,Global Street",empdet_residentialPostCode="121",},
            };
            EmployeeDetail.ForEach(s => context.tbl_EmployeeDetails.Add(s));
            context.SaveChanges();
            var City = new List<tbl_city>
            {
            new tbl_city{cit_name="London",cit_couId=1,},
            new tbl_city{cit_name="Faridabad",cit_couId=2,},

            };
            City.ForEach(s => context.tbl_city.Add(s));
            context.SaveChanges();

            var Country = new List<tbl_Country>
            {
            new tbl_Country{cou_Name="UK"},
            new tbl_Country{cou_Name="India"},

            };
            Country.ForEach(s => context.tbl_Country.Add(s));
            context.SaveChanges();



        }
    }
}