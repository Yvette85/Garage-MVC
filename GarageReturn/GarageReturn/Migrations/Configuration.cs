namespace GarageReturn.Migrations
{
    using GarageReturn.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GarageReturn.DataAccessLayer.StorageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GarageReturn.DataAccessLayer.StorageContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.



            var vehiclesTypes = new[] {
                new VehicleType { Name = "Bus" },
                new VehicleType { Name= "Car" },
                new VehicleType { Name = "Motorcycle" },
                new VehicleType { Name = "Truck" },
             

                };
            context.VehicleTypes.AddOrUpdate(s => s.Name, vehiclesTypes);

            context.SaveChanges();


            var members = new[] {
                new Member { FirstName = "Adam", LastName = "Pherson", Email = "adam@inter.net" },
                new Member { FirstName = "Bo", LastName = "Bosson", Email = "bo@inter.net" },
                new Member { FirstName = "George", LastName = "Gershwing", Email = "george@inter.net" },
                new Member { FirstName = "Juliet", LastName = "Johnson", Email = "juliet@inter.net" },
                new Member { FirstName = "Harold", LastName = "Haroldson", Email = "harold@inter.net" }

                 };
            //context.Members.AddOrUpdate(s => s.FirstName, members);
            //context.Members.AddOrUpdate(s => s.LastName, members);
            context.Members.AddOrUpdate(s => s.Email, members);

            context.SaveChanges();

          


            ParkedVehicle P = new ParkedVehicle() { RegNum = " EDS882", Color = " Blue", Brand = " BMW", Model = "Z4 ", NumberOfWheels = 4, ParkedTime=DateTime.Now, MemberId= context.Members.First().Id , VehiclesTypeId =context.VehicleTypes.First().Id};
            //context.vehicles.AddOrUpdate(t => t.Id, P);
            //context.vehicles.AddOrUpdate(t => t.VehicleTypes, P);
            context.vehicles.AddOrUpdate(t => t.RegNum, P);
            //context.vehicles.AddOrUpdate(t => t.Color, P);
            //context.vehicles.AddOrUpdate(t => t.Brand, P);
            //context.vehicles.AddOrUpdate(t => t.Model, P);
            //context.vehicles.AddOrUpdate(t => t.NumberOfWheels, P);



            //List<ParkedVehicle> par = new List<ParkedVehicle>();

            //foreach (var member in members)
            //{
             
            //    par.Add(new ParkedVehicle {RegNum = rg, MemberId = member.Id });
            //}
            //context.vehicles.AddOrUpdate(t => t.RegNum, par.ToArray());



            ////List<ParkedVehicle> numbers = new List<ParkedVehicle>();

            ////foreach (var member in members)
            ////{ 
            ////    //var random = new Random(student.Id);
            ////    //var nr = random.Next(10000000, 99999999).ToString();
            ////numbers.Add(new PhoneNumber { Number = nr, StudentId = student.Id });
            ////}
            ////db.PhoneNumbers.AddOrUpdate(p => p.Number, numbers.ToArray());


        }


    }
}



