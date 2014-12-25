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
    public class CarController : Controller
    {
        private DB_JoshuaEntities db = new DB_JoshuaEntities();

        //
        // GET: /Car/

        public ActionResult Index()
        {
            var cars = db.Cars.Include(c => c.CarMake);
            return View(cars.ToList());
        }

        //
        // GET: /Car/Details/5

        public ActionResult Details(int id = 0)
        {
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        //
        // GET: /Car/Create

        public ActionResult Create()
        {
            ViewBag.Make_Id = new SelectList(db.CarMakes, "Make_Id", "Make");
            return View();
        }

        //
        // POST: /Car/Create

        [HttpPost]
        public ActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                db.Cars.Add(car);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Make_Id = new SelectList(db.CarMakes, "Make_Id", "Make", car.Make_Id);
            return View(car);
        }

        //
        // GET: /Car/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            ViewBag.Make_Id = new SelectList(db.CarMakes, "Make_Id", "Make", car.Make_Id);
            return View(car);
        }

        //
        // POST: /Car/Edit/5

        [HttpPost]
        public ActionResult Edit(Car car)
        {
            if (ModelState.IsValid)
            {
                db.Entry(car).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Make_Id = new SelectList(db.CarMakes, "Make_Id", "Make", car.Make_Id);
            return View(car);
        }

        //
        // GET: /Car/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        //
        // POST: /Car/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Car car = db.Cars.Find(id);
            db.Cars.Remove(car);
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