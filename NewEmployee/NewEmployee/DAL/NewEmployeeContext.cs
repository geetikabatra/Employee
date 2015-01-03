using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using NewEmployee.Models;


namespace NewEmployee.DAL
{
    public class NewEmployeeContext:DbContext
    {
        public NewEmployeeContext():base("MyDB")
        {
            
        }
        public DbSet<tbl_Employee> tbl_Employees { get; set; }
        public DbSet<tbl_EmployeeDetails> tbl_Employee_Details{ get; set; }
        public DbSet<tbl_city> tbl_Cities { get; set; }
        public DbSet<tbl_Country> tbl_Countries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}