using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using NewEmployee.DAL;

namespace NewEmployee
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
        protected void Application_Start()
        {

            Database.SetInitializer<NewEmployeeContext>(new NewEmployeeInitializer());

        }
    }
}
