using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NewEmployee.Models.NewEmployee
{
    public class NewEmployeeContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public NewEmployeeContext() : base("name=NewEmployeeContext")
        {
        }

        public System.Data.Entity.DbSet<NewEmployee.Models.tbl_city> tbl_city { get; set; }
    
    }
}
