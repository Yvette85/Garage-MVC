using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageReturn.Models
{
    public class IndexVehicle
    {
        public int Id { get; set; }
        public VehiclesTypes VehicleTypes { get; set; }
        public string RegNum { get; set; }
        public string Color { get; set; }
       

        public IndexVehicle(ParkedVehicle v)
        {
            Id = v.Id;
            VehicleTypes = v.VehicleTypes;
            RegNum = v.RegNum;
            Color = v.Color;
           

        }
    }
}