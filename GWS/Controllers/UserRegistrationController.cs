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
    public class UserRegistrationController : Controller
    {
        //private DB_JoshuaEntities db = new DB_JoshuaEntities();

        ////
        //// GET: /UserRegistration/

        //public ActionResult Index()
        //{
        //    return View(db.userinfoes.ToList());
        //}

        ////
        //// GET: /UserRegistration/Details/5

        //public ActionResult Details(int id = 0)
        //{
        //    userinfo userinfo = db.userinfoes.Find(id);
        //    if (userinfo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(userinfo);
        //}

        ////
        //// GET: /UserRegistration/Create

        //public ActionResult Create()
        //{
        //    return View();
        //}

        ////
        //// POST: /UserRegistration/Create

        //[HttpPost]
        //public ActionResult Create(userinfo userinfo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.userinfoes.Add(userinfo);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(userinfo);
        //}

        ////
        //// GET: /UserRegistration/Edit/5

        //public ActionResult Edit(int id = 0)
        //{
        //    userinfo userinfo = db.userinfoes.Find(id);
        //    if (userinfo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(userinfo);
        //}

        ////
        //// POST: /UserRegistration/Edit/5

        //[HttpPost]
        //public ActionResult Edit(userinfo userinfo)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(userinfo).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(userinfo);
        //}

        ////
        //// GET: /UserRegistration/Delete/5

        //public ActionResult Delete(int id = 0)
        //{
        //    userinfo userinfo = db.userinfoes.Find(id);
        //    if (userinfo == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(userinfo);
        //}

        ////
        //// POST: /UserRegistration/Delete/5

        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    userinfo userinfo = db.userinfoes.Find(id);
        //    db.userinfoes.Remove(userinfo);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    db.Dispose();
        //    base.Dispose(disposing);
        //}
    }
}