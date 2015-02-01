using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employee.Models;

namespace Employee.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SqlConnection()
        {

            int emp_Id = Convert.ToInt32(Request["emp_Id"]);

            string emp_passwd = Request["emp_passwd"];
            EmployeeEntities2 OE=new EmployeeEntities2();
            var details = OE.EmployeeDatabases.Where(p => p.emp_Id == emp_Id).FirstOrDefault();
            if (details.emp_IsAdmin)
                return RedirectToAction("Index", "EmployeeDatabases");
            else

                ViewBag.LR = details;
           
             return View();
        }
    }
}