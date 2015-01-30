using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EmployeeMvc.Models;

namespace EmployeeMvc.DAL
{
    public class EmployeeInitializer:System.Data.Entity.DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void seed(EmployeeContext Context)
        {
            var EmployeeDetails = new List<tbl_EmployeeDetails>
             {
                    new tbl_EmployeeDetails{empdet_FirstName="Jack",empdet_MiddleName="Carson",empdet_LastName="Alexander",empdet_CityId=1050,empdet_residentialAddress="24,Global Street",empdet_residentialPostCode="GS-1"},
                    new tbl_EmployeeDetails{empdet_FirstName="Meredith",empdet_MiddleName="Alonso",empdet_LastName="Grey",empdet_CityId=1050,empdet_residentialAddress="12,Sunset Boulevard",empdet_residentialPostCode="SB-3"},
    
             };
            EmployeeDetails.ForEach(s => Context.EmployeeDetails.Add(s));
            Context.SaveChanges();

            var Employee = new List<tbl_Employee>
            {
                new tbl_Employee{emp_Login="JCA",emp_Password="JCA12",emp_CreateDate=DateTime.Parse("2005-09-01"),emp_LastLogin=DateTime.Parse("0:12:33"),emp_IsRemove=false},
                new tbl_Employee{emp_Login="MAG",emp_Password="MAG12",emp_CreateDate=DateTime.Parse("2005-09-01"),emp_LastLogin=DateTime.Parse("0:12:33"),emp_IsRemove=false},
            };
            Employee.ForEach(s => Context.Employee.Add(s));
            Context.SaveChanges();
            var city = new List<tbl_city>
            {
                new tbl_city{cit_Id=1050,cit_name="London",cit_couId=1234},
                new tbl_city{cit_Id=1051,cit_name="Faridabad",cit_couId=5678},
            };
            city.ForEach(s => Context.city.Add(s));
            Context.SaveChanges();
            var Country = new List<tbl_Country>
            {
                new tbl_Country{cou_Id=1234,cou_Name="United Kingdom"},
                new tbl_Country{cou_Id=5678,cou_Name="India"},
            };
            Country.ForEach(s => Context.Country.Add(s));
            Context.SaveChanges();



        }
    }
}