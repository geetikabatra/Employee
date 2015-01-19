using NewEmployee.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure;

namespace NewEmployee.DAL
{


    public partial class NewEmployeeContext : DbContext
    {
        public NewEmployeeContext()
            : base("name=NewEmployeeContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public virtual DbSet<City> tbl_city { get; set; }
        public virtual DbSet<Country>tbl_Country { get; set; }
        public virtual DbSet<Employee> tbl_Employee { get; set; }
        public virtual DbSet<EmployeeDetails> tbl_EmployeeDetails { get; set; }
    }
}
