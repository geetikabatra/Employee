using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Employee.Models;

namespace Employee.Controllers
{
    public class EmployeeDatabasesController : Controller
    {
        private EmployeeEntities2 db = new EmployeeEntities2();

        // GET: EmployeeDatabases
        public ActionResult Index()
        {
            return View(db.EmployeeDatabases.ToList());
        }

        // GET: EmployeeDatabases/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeDatabase employeeDatabase = db.EmployeeDatabases.Find(id);
            if (employeeDatabase == null)
            {
                return HttpNotFound();
            }
            return View(employeeDatabase);
        }

        // GET: EmployeeDatabases/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeDatabases/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "emp_Id,emp_login,emp_Password,emp_CreateDate,emp_lastLogin,emp_IsRemove,emp_FirstName,emp_MiddleName,emp_LastName,emp_CityName,emp_CountryName,emp_ResidentialAddress,emp_ResidentialPostCode,emp_IsAdmin")] EmployeeDatabase employeeDatabase)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeDatabases.Add(employeeDatabase);
               
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeDatabase);
        }

        // GET: EmployeeDatabases/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeDatabase employeeDatabase = db.EmployeeDatabases.Find(id);
            if (employeeDatabase == null)
            {
                return HttpNotFound();
            }
            return View(employeeDatabase);
        }

        // POST: EmployeeDatabases/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "emp_Id,emp_login,emp_Password,emp_CreateDate,emp_lastLogin,emp_IsRemove,emp_FirstName,emp_MiddleName,emp_LastName,emp_CityName,emp_CountryName,emp_ResidentialAddress,emp_ResidentialPostCode,emp_IsAdmin")] EmployeeDatabase employeeDatabase)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeDatabase).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeDatabase);
        }

        // GET: EmployeeDatabases/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeDatabase employeeDatabase = db.EmployeeDatabases.Find(id);
            if (employeeDatabase == null)
            {
                return HttpNotFound();
            }
            return View(employeeDatabase);
        }

        // POST: EmployeeDatabases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeDatabase employeeDatabase = db.EmployeeDatabases.Find(id);
            db.EmployeeDatabases.Remove(employeeDatabase);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
