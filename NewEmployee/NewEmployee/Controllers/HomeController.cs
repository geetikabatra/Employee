using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewEmployee;




namespace NewEmployee.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult LogIn(string user_id,string _password)
        {
            return View();
        }
        public ActionResult LogInResult()
        {
            return View();
        }
        public ActionResult ViewAllEmployees()
        {
           NewEmployeeDatabaseEntities2 NDE = new NewEmployeeDatabaseEntities2();
           return View();
        }


       
    }
}