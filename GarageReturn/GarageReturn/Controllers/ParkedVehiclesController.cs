using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GarageReturn.DataAccessLayer;
using GarageReturn.Models;

namespace GarageReturn.Controllers
{
    public class ParkedVehiclesController : Controller
    {
        private StorageContext db = new StorageContext();
      
        // GET: ParkedVehicles
        public ActionResult Index( string sortOrder)

        {







            List<IndexVehicle> iv = new List<IndexVehicle>();
            foreach (ParkedVehicle e in db.vehicles.ToList())

            {
                iv.Add(new IndexVehicle(e));
            }
            return View(iv);
        }
        [HttpPost]
        public ActionResult Search(string search)
        {

            List<IndexVehicle> iv = new List<IndexVehicle>();

            foreach (ParkedVehicle e in db.vehicles.Where(s => s.RegNum.Contains(search) || s.Color.Contains(search)).ToList())


            {
                iv.Add(new IndexVehicle(e));
            }

            return View("Index", iv);


        }





        // GET: ParkedVehicles/Details/5

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParkedVehicle parkedVehicle = db.vehicles.Find(id);
            if (parkedVehicle == null)
            {
                return HttpNotFound();
            }
            return View(parkedVehicle);
        }

            // GET: ParkedVehicles/Create

            public ActionResult Create()
            {
                return View();
            }

        // POST: ParkedVehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Type,RegNum,Color,Brand,Model,NumberOfWheels")] ParkedVehicle parkedVehicle)
        {
            if (ModelState.IsValid)
            {
                db.vehicles.Add(parkedVehicle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parkedVehicle);
        }








        // GET: ParkedVehicles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParkedVehicle parkedVehicle = db.vehicles.Find(id);
            if (parkedVehicle == null)
            {
                return HttpNotFound();
            }
            return View(parkedVehicle);
        }

        // POST: ParkedVehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Type,RegNum,Color,Brand,Model,NumberOfWheels")] ParkedVehicle parkedVehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parkedVehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parkedVehicle);
        }

        // GET: ParkedVehicles/Delete/5
        public ActionResult Delete(int? id )
        {
            
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParkedVehicle parkedVehicle = db.vehicles.Find(id);

            VehiclesViewModel s = new VehiclesViewModel (parkedVehicle.Id, parkedVehicle.RegNum, parkedVehicle.VehicleTypes, DateTime.Now, parkedVehicle.ParkedTime);


            if (parkedVehicle == null)
            {
                return HttpNotFound();
            }
            return View(s);
        }

        // POST: ParkedVehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]


        public ActionResult DeleteConfirmed(int id)
        {
           

            ParkedVehicle parkedVehicle = db.vehicles.Find(id);

            VehiclesViewModel I = new VehiclesViewModel(parkedVehicle.Id, parkedVehicle.RegNum, parkedVehicle.VehicleTypes, DateTime.Now, parkedVehicle.ParkedTime);
            db.vehicles.Remove(parkedVehicle);
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
