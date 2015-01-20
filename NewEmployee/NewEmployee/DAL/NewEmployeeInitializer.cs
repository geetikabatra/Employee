using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NewEmployee.Models;


namespace NewEmployee.DAL
{
    public class NewEmployeeInitializer :IDatabaseInitializer<NewEmployeeContext>
    {
        protected override void Seed(NewEmployeeContext context)
        {
            var Employees = new List<Employee>
            {
            new Employee{emp_Login="Carson",emp_Password="Alexander",emp_CreateDate=DateTime.Parse("2005-09-01"),emp_LastLogin=DateTime.Parse("2005-09-01"),emp_IsRemove=false},
            new Employee{emp_Login="Naruto",emp_Password="Alex",emp_CreateDate=DateTime.Parse("2005-09-01"),emp_LastLogin=DateTime.Parse("2005-09-01"),emp_IsRemove=false},
            new Employee{emp_Login="Geetika",emp_Password="saibabaji",emp_CreateDate=DateTime.Parse("2005-09-01"),emp_LastLogin=DateTime.Parse("2005-09-01"),emp_IsRemove=false},
            };
            Employees.ForEach(s => context.tbl_Employee.Add(s));
            context.SaveChanges();

            var EmployeeDetail = new List<EmployeeDetails>
            {
            new EmployeeDetails{empdet_empId=1,empdet_FirstName="Geetika",empdet_MiddleName="",empdet_LastName="Batra",empdet_CityId=2,empdet_residentialAddress="22,Global Street",empdet_residentialPostCode="121",},
            new EmployeeDetails{empdet_empId=1,empdet_FirstName="Jay",empdet_MiddleName="",empdet_LastName="Batra",empdet_CityId=2,empdet_residentialAddress="22,Global Street",empdet_residentialPostCode="121",},
            };
            EmployeeDetail.ForEach(s => context.tbl_EmployeeDetails.Add(s));
            context.SaveChanges();
            var City = new List<City>
            {
            new City{cit_name="London",cit_couId=1,},
            new City{cit_name="Faridabad",cit_couId=2,},
           
            };
            City.ForEach(s => context.tbl_city.Add(s));
            context.SaveChanges();

            var Country = new List<Country>
            {
            new Country{cou_Name="UK"},
            new Country{cou_Name="India"},
           
            };
            Country.ForEach(s => context.tbl_Country.Add(s));
            context.SaveChanges();



        }
    }
}