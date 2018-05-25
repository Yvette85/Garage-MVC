using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GarageReturn.Models;

namespace GarageReturn.DataAccessLayer
{
    public class StorageContext : DbContext
    {
        public StorageContext() : base ("Exercise12")
        {

        }
        public DbSet<ParkedVehicle> vehicles{ get; set; }
    }
}