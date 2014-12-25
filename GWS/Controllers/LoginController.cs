using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GWS.Models;

namespace GWS.Controllers
{
    public class LoginController : Controller
    {
        private DB_JoshuaEntities db = new DB_JoshuaEntities();

        //
        // GET: /Login/

        public ActionResult Index()
        {
            var tbllogins = db.tblLogins.Include(t => t.Country);
            return View(tbllogins.ToList());
        }

        //
        // GET: /Login/Details/5

        public ActionResult Details(int id = 0)
        {
            tblLogin tbllogin = db.tblLogins.Find(id);
            if (tbllogin == null)
            {
                return HttpNotFound();
            }
            return View(tbllogin);
        }

        //
        // GET: /Login/Create

        public ActionResult Create()
        {
            ViewBag.CountryCode = new SelectList(db.Countries, "Country_Id", "CountryName");
            return View();
        }

        //
        // POST: /Login/Create

        [HttpPost]
        public ActionResult Create(tblLogin tbllogin)
        {
            if (ModelState.IsValid)
            {
                db.tblLogins.Add(tbllogin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CountryCode = new SelectList(db.Countries, "Country_Id", "CountryName", tbllogin.CountryCode);
            return View(tbllogin);
        }

        //
        // GET: /Login/Edit/5

        public ActionResult Edit(int id = 0)
        {
            tblLogin tbllogin = db.tblLogins.Find(id);
            if (tbllogin == null)
            {
                return HttpNotFound();
            }
            ViewBag.CountryCode = new SelectList(db.Countries, "Country_Id", "CountryName", tbllogin.CountryCode);
            return View(tbllogin);
        }

        //
        // POST: /Login/Edit/5

        [HttpPost]
        public ActionResult Edit(tblLogin tbllogin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbllogin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CountryCode = new SelectList(db.Countries, "Country_Id", "CountryName", tbllogin.CountryCode);
            return View(tbllogin);
        }

        //
        // GET: /Login/Delete/5

        public ActionResult Delete(int id = 0)
        {
            tblLogin tbllogin = db.tblLogins.Find(id);
            if (tbllogin == null)
            {
                return HttpNotFound();
            }
            return View(tbllogin);
        }

        //
        // POST: /Login/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            tblLogin tbllogin = db.tblLogins.Find(id);
            db.tblLogins.Remove(tbllogin);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}