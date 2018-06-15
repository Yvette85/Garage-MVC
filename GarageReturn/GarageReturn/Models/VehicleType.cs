using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageReturn.Models
{
    public class VehicleType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        

        public virtual ICollection<ParkedVehicle> parkedvehicle { get; set; }
    }
}