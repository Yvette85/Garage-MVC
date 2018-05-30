namespace GarageReturn.Migrations
{
    using GarageReturn.Models;
    using System;
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

            ParkedVehicle P = new ParkedVehicle() { VehicleTypes = VehiclesTypes.Bus, RegNum = " EDS882", Color = " Blue", Brand = " BMW", Model = "Z4 ", NumberOfWheels = 4, ParkedTime=DateTime.Now };
            context.vehicles.AddOrUpdate(t => t.Id, P);
            context.vehicles.AddOrUpdate(t => t.VehicleTypes, P);
            context.vehicles.AddOrUpdate(t => t.RegNum, P);
            context.vehicles.AddOrUpdate(t => t.Color, P);
            context.vehicles.AddOrUpdate(t => t.Brand, P);
            context.vehicles.AddOrUpdate(t => t.Model, P);
            context.vehicles.AddOrUpdate(t => t.NumberOfWheels, P);

        }
    }
}
