using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeMvc.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EmployeeMvc.DAL
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("geetika\SQLExpress")
    {

    }
        public DbSet<tbl_city> city{get;set;}
        public DbSet<tbl_Country>Country{get;set;}
        public DbSet<tbl_Employee>Employee{get;set;}
        public DbSet<tbl_EmployeeDetails>EmployeeDetails{get;set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }



    }
}