
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageReturn.Models
{
    public class ParkedVehicle
    {

        public int Id { get; set; }
        public VehiclesTypes VehicleTypes { get; set; }
        public string RegNum { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
        public DateTime ParkedTime { get; set; }

    }
    public enum VehiclesTypes
    {
        Bus,
        Car,
        Motorcycle,
        Truck
    }

}