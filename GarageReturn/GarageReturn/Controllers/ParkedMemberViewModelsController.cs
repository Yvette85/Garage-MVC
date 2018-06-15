//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using GarageReturn.DataAccessLayer;

//namespace GarageReturn.Models
//{
//    public class ParkedMemberViewModelsController : Controller
//    {
//        private StorageContext db = new StorageContext();

//        // GET: ParkedMemberViewModels
//        public ActionResult Index()
//        {
          

            
           
           
//            return View(parkedMemberViewModels.ToList());
//        }

//        // GET: ParkedMemberViewModels/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ParkedMemberViewModel parkedMemberViewModel = db.ParkedMemberViewModels.Find(id);
//            if (parkedMemberViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(parkedMemberViewModel);
//        }

//        // GET: ParkedMemberViewModels/Create
//        public ActionResult Create()
//        {
//            ViewBag.MemberId = new SelectList(db.Members, "Id", "FirstName");
//            return View();
//        }

//        // POST: ParkedMemberViewModels/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Id,VehicleTypes,RegNum,Color,Brand,Model,NumberOfWheels,ParkedTime,MemberId")] ParkedMemberViewModel parkedMemberViewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                db.ParkedMemberViewModels.Add(parkedMemberViewModel);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            ViewBag.MemberId = new SelectList(db.Members, "Id", "FirstName", parkedMemberViewModel.MemberId);
//            return View(parkedMemberViewModel);
//        }

//        // GET: ParkedMemberViewModels/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ParkedMemberViewModel parkedMemberViewModel = db.ParkedMemberViewModels.Find(id);
//            if (parkedMemberViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            ViewBag.MemberId = new SelectList(db.Members, "Id", "FirstName", parkedMemberViewModel.MemberId);
//            return View(parkedMemberViewModel);
//        }

//        // POST: ParkedMemberViewModels/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Id,VehicleTypes,RegNum,Color,Brand,Model,NumberOfWheels,ParkedTime,MemberId")] ParkedMemberViewModel parkedMemberViewModel)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(parkedMemberViewModel).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            ViewBag.MemberId = new SelectList(db.Members, "Id", "FirstName", parkedMemberViewModel.MemberId);
//            return View(parkedMemberViewModel);
//        }

//        // GET: ParkedMemberViewModels/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            ParkedMemberViewModel parkedMemberViewModel = db.ParkedMemberViewModels.Find(id);
//            if (parkedMemberViewModel == null)
//            {
//                return HttpNotFound();
//            }
//            return View(parkedMemberViewModel);
//        }

//        // POST: ParkedMemberViewModels/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            ParkedMemberViewModel parkedMemberViewModel = db.ParkedMemberViewModels.Find(id);
//            db.ParkedMemberViewModels.Remove(parkedMemberViewModel);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}
