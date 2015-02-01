using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Employee.Startup))]
namespace Employee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
