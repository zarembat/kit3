using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Insurance_Company.Models;

namespace Insurance_Company.Controllers
{
    public class EmployeeController : Controller
    {
        private InsuranceCompanyEntities db = new InsuranceCompanyEntities();

        // GET: /Employee/
        public ActionResult Index()
        {
            return View(db.EmployeeSet.ToList());
        }

        // GET: /Employee/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeSet employeeset = db.EmployeeSet.Find(id);
            if (employeeset == null)
            {
                return HttpNotFound();
            }
            return View(employeeset);
        }

        // GET: /Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Employee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Login,Password,Name,Surname,Role")] EmployeeSet employeeset)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeSet.Add(employeeset);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employeeset);
        }

        // GET: /Employee/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeSet employeeset = db.EmployeeSet.Find(id);
            if (employeeset == null)
            {
                return HttpNotFound();
            }
            return View(employeeset);
        }

        // POST: /Employee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Login,Password,Name,Surname,Role")] EmployeeSet employeeset)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employeeset).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employeeset);
        }

        // GET: /Employee/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeSet employeeset = db.EmployeeSet.Find(id);
            if (employeeset == null)
            {
                return HttpNotFound();
            }
            return View(employeeset);
        }

        // POST: /Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeSet employeeset = db.EmployeeSet.Find(id);
            db.EmployeeSet.Remove(employeeset);
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
