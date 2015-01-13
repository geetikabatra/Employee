//namespace NewEmployee
//{
//    using System;
//    using System.Data.Entity;
//    using System.Data.Entity.Infrastructure;
    
//    public partial class NewEmployeeDatabaseEntities3 : DbContext
//    {
//        public NewEmployeeDatabaseEntities3()
//            : base("name=NewEmployeeDatabaseEntities3")
//        {
//        }
    
//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//            throw new UnintentionalCodeFirstException();
//        }
    
//        public virtual DbSet<tbl_city> tbl_city { get; set; }
//        public virtual DbSet<tbl_Country> tbl_Country { get; set; }
//        public virtual DbSet<tbl_Employee> tbl_Employee { get; set; }
//        public virtual DbSet<tbl_EmployeeDetails> tbl_EmployeeDetails { get; set; }
//    }
//}
