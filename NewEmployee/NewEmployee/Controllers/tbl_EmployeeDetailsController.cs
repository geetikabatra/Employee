using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NewEmployee.Models;


namespace NewEmployee.Controllers
{
    [RoutePrefix("tbl_EmployeeDetails")]
    [Route("{action}/{id}")]
    public class tbl_EmployeeDetailsController : Controller
    {
        private NewEmployeeContext db = new NewEmployeeContext();

        // GET: tbl_EmployeeDetails
        [Route]
        public ActionResult Index()
        {
            return View(db.tbl_EmployeeDetails.ToList());
        }

        // GET: tbl_EmployeeDetails/Details/5
        public ActionResult Details(int id)
        {
            tbl_EmployeeDetails tbl_EmployeeDetails = db.tbl_EmployeeDetails.Find(id);
            if (tbl_EmployeeDetails == null)
            {
                return HttpNotFound();
            }
            return View(tbl_EmployeeDetails);
        }

        // GET: tbl_EmployeeDetails/Create
        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_EmployeeDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="empdet_id,empdet_empId,empdet_FirstName,empdet_MiddleName,empdet_LastName,empdet_CityId,empdet_residentialAddress,empdet_residentialPostCode")] tbl_EmployeeDetails tbl_EmployeeDetails)
        {
            if (ModelState.IsValid)
            {
                db.tbl_EmployeeDetails.Add(tbl_EmployeeDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_EmployeeDetails);
        }

        // GET: tbl_EmployeeDetails/Edit/5
        public ActionResult Edit(int id)
        {
            tbl_EmployeeDetails tbl_EmployeeDetails = db.tbl_EmployeeDetails.Find(id);
            if (tbl_EmployeeDetails == null)
            {
                return HttpNotFound();
            }
            return View(tbl_EmployeeDetails);
        }

        // POST: tbl_EmployeeDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="empdet_id,empdet_empId,empdet_FirstName,empdet_MiddleName,empdet_LastName,empdet_CityId,empdet_residentialAddress,empdet_residentialPostCode")] tbl_EmployeeDetails tbl_EmployeeDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_EmployeeDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_EmployeeDetails);
        }

        // GET: tbl_EmployeeDetails/Delete/5
        public ActionResult Delete(int id)
        {
            tbl_EmployeeDetails tbl_EmployeeDetails = db.tbl_EmployeeDetails.Find(id);
            if (tbl_EmployeeDetails == null)
            {
                return HttpNotFound();
            }
            return View(tbl_EmployeeDetails);
        }

        // POST: tbl_EmployeeDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_EmployeeDetails tbl_EmployeeDetails = db.tbl_EmployeeDetails.Find(id);
            db.tbl_EmployeeDetails.Remove(tbl_EmployeeDetails);
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
