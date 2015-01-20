using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NewEmployee.Models;
using NewEmployee.Models.NewEmployee;

namespace NewEmployee.Controllers
{
    [RoutePrefix("tbl_city")]
    [Route("{action}/{id}")]
    public class tbl_cityController : Controller
    {
        private NewEmployeeContext db = new NewEmployeeContext();

        // GET: tbl_city
        [Route]
        public ActionResult Index()
        {
            return View(db.tbl_city.ToList());
        }

        // GET: tbl_city/Details/5
        public ActionResult Details(int id)
        {
            tbl_city tbl_city = db.tbl_city.Find(id);
            if (tbl_city == null)
            {
                return HttpNotFound();
            }
            return View(tbl_city);
        }

        // GET: tbl_city/Create
        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_city/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="cit_Id,cit_name,cit_couId")] tbl_city tbl_city)
        {
            if (ModelState.IsValid)
            {
                db.tbl_city.Add(tbl_city);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_city);
        }

        // GET: tbl_city/Edit/5
        public ActionResult Edit(int id)
        {
            tbl_city tbl_city = db.tbl_city.Find(id);
            if (tbl_city == null)
            {
                return HttpNotFound();
            }
            return View(tbl_city);
        }

        // POST: tbl_city/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="cit_Id,cit_name,cit_couId")] tbl_city tbl_city)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_city).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_city);
        }

        // GET: tbl_city/Delete/5
        public ActionResult Delete(int id)
        {
            tbl_city tbl_city = db.tbl_city.Find(id);
            if (tbl_city == null)
            {
                return HttpNotFound();
            }
            return View(tbl_city);
        }

        // POST: tbl_city/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_city tbl_city = db.tbl_city.Find(id);
            db.tbl_city.Remove(tbl_city);
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
