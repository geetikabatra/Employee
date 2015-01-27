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
    [RoutePrefix("tbl_Country")]
    [Route("{action}/{id}")]
    public class tbl_CountryController : Controller
    {
        private NewEmployeeContext db = new NewEmployeeContext();

        // GET: tbl_Country
        [Route]
        public ActionResult Index()
        {
            return View(db.tbl_Country.ToList());
        }

        // GET: tbl_Country/Details/5
        public ActionResult Details(int id)
        {
            tbl_Country tbl_Country = db.tbl_Country.Find(id);
            if (tbl_Country == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Country);
        }

        // GET: tbl_Country/Create
        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_Country/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="cou_Id,cou_Name")] tbl_Country tbl_Country)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Country.Add(tbl_Country);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_Country);
        }

        // GET: tbl_Country/Edit/5
        public ActionResult Edit(int id)
        {
            tbl_Country tbl_Country = db.tbl_Country.Find(id);
            if (tbl_Country == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Country);
        }

        // POST: tbl_Country/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="cou_Id,cou_Name")] tbl_Country tbl_Country)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_Country).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_Country);
        }

        // GET: tbl_Country/Delete/5
        public ActionResult Delete(int id)
        {
            tbl_Country tbl_Country = db.tbl_Country.Find(id);
            if (tbl_Country == null)
            {
                return HttpNotFound();
            }
            return View(tbl_Country);
        }

        // POST: tbl_Country/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Country tbl_Country = db.tbl_Country.Find(id);
            db.tbl_Country.Remove(tbl_Country);
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
