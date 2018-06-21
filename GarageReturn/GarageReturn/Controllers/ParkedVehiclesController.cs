 using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using GarageReturn.DataAccessLayer;
using GarageReturn.Models;

namespace GarageReturn.Controllers
{
    public class ParkedVehiclesController : Controller
    {


        private StorageContext db = new StorageContext();


      
        //GET: ParkedVehicles
       
            public ActionResult Index(string sortOrder)

        {
            
            var park = db.Members.ToList();
            var parkedVehicle = db.vehicles.ToList();

            if (sortOrder == "Ascending")
            {
                parkedVehicle = parkedVehicle.OrderBy(s => s.RegNum).ToList();
            }

            else if (sortOrder == "Descending")
            {
                parkedVehicle = parkedVehicle.OrderByDescending(s => s.RegNum).ToList();
            }


            List<IndexVehicle> iv = new List<IndexVehicle>();

       

            foreach (ParkedVehicle e in parkedVehicle.ToList())

            {
                iv.Add(new IndexVehicle(e));
              
            }
            return View(iv);
        }
        [HttpPost]
        public ActionResult Search(string search)
        {
            

        List<IndexVehicle> iv = new List<IndexVehicle>();

         

            foreach (ParkedVehicle e in db.vehicles.Where(s => s.RegNum.Contains(search) || s.VehiclesType.Name.Contains(search) || s.Color.Contains(search)).ToList() )

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
            Park park = new Park(parkedVehicle.Brand,parkedVehicle.Color, parkedVehicle.Model, parkedVehicle.ParkedTime, parkedVehicle.RegNum, parkedVehicle.NumberOfWheels,parkedVehicle.VehiclesTypeId , parkedVehicle.MemberId);


            //VehiclesViewModel s = new VehiclesViewModel(parkedVehicle.Id, parkedVehicle.RegNum, parkedVehicle.VehicleTypes, DateTime.Now, parkedVehicle.ParkedTime); 


            if (parkedVehicle == null)
            {
                return HttpNotFound();
            }

            parkedVehicle.Color = park.Color;
            parkedVehicle.Brand = park.Brand;
            parkedVehicle.Model = park.Model;
            parkedVehicle.NumberOfWheels = park.NumberOfWheels;
            parkedVehicle.RegNum = park.RegNum;
            parkedVehicle.MemberId = park.MemberId;
            parkedVehicle.VehiclesTypeId = park.VehicleTypesId;
            parkedVehicle.ParkedTime = DateTime.Now;
            return View(park);
        }

            // GET: ParkedVehicles/Create

            public ActionResult Create()
            {
            var members = db.Members.ToList();

            Park park = new Park();
        park.ListMembers = members.Select(x => new SelectListItem()
            {
                Text = x.FirstName,
                Value = x.Id.ToString(),
            });

            var vehiclesTypes = db.VehicleTypes.ToList();

            park.ListVehicleTypes = vehiclesTypes.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });


            return View(park);
        }
          




        // POST: ParkedVehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RegNum,Color,Brand,Model,NumberOfWheels,ParkedTime, MemberId,VehicleTypesId")] Park park)
        {
          

        var parkedVehicle = new ParkedVehicle();

            if (ModelState.IsValid)
            {
                parkedVehicle.Color = park.Color;
                parkedVehicle.Brand = park.Brand;
                parkedVehicle.Model = park.Model;
                parkedVehicle.NumberOfWheels = park.NumberOfWheels;
                parkedVehicle.RegNum = park.RegNum;
                parkedVehicle.MemberId = park.MemberId;
                parkedVehicle.VehiclesTypeId = park.VehicleTypesId;
                parkedVehicle.ParkedTime = DateTime.Now;
                db.vehicles.Add(parkedVehicle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(park);

            //VehiclesViewModel s = new VehiclesViewModel(parkedVehicle.Id, parkedVehicle.RegNum, parkedVehicle.VehicleTypes, DateTime.Now, parkedVehicle.ParkedTime); 

        }








        // GET: ParkedVehicles/Edit/5
        public ActionResult Edit(int? id)
        {
     
 
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ParkedVehicle parkedVehicle = db.vehicles.Find(id);
            EditViewModel ed = new EditViewModel(parkedVehicle.Id, parkedVehicle.Color, parkedVehicle.Brand, parkedVehicle.Color, parkedVehicle.NumberOfWheels , parkedVehicle.RegNum);
            if (parkedVehicle == null)
            {
                return HttpNotFound();
            }
            return View(ed);
        }

        // POST: ParkedVehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken] 
        public ActionResult Edit([Bind(Include = "Id,Color,Brand,Model,NumberOfWheels,RegNum ")] EditViewModel editv )
        {


       
            if (ModelState.IsValid)
            {

                ParkedVehicle pv = db.vehicles.FirstOrDefault(x => x.Id == editv.Id);

                pv.RegNum = editv.RegNum;
                pv.Brand = editv.Brand;
                pv.Model = editv.Model;
                pv.NumberOfWheels = editv.NumberOfWheels  ;
                pv.RegNum = editv.RegNum;


                

                //db.Entry(editv).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(editv);
        }

        // GET: ParkedVehicles/Delete/5
        public ActionResult Delete(int? id )
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

            VehiclesViewModel s = new VehiclesViewModel(parkedVehicle.Id, parkedVehicle.RegNum, DateTime.Now, parkedVehicle.ParkedTime);

            return View(s);
        }

        // POST: ParkedVehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]


        public ActionResult DeleteConfirmed(int id)
        {
           

            ParkedVehicle parkedVehicle = db.vehicles.Find(id);

            ReceiptViewModel s = new ReceiptViewModel(parkedVehicle.Id, parkedVehicle.RegNum, DateTime.Now, parkedVehicle.ParkedTime, 1.5M);
          
          

            db.vehicles.Remove(parkedVehicle);

            db.SaveChanges();

            return View("ReceiptView" ,s);

           
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
