using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageReturn.Models
{
    public class IndexVehicle
    {
        public Member member;

        public int Id { get; set; }
        //public Vehicle VehicleTypes { get; set; }
        public string RegNum { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public string VehType { get; set; }
        public DateTime ParkedTime { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }

        public IndexVehicle(ParkedVehicle v )

        {
            Id = v.Id;
            //VehicleTypes = v.VehicleTypes;
            RegNum = v.RegNum;
            Color = v.Color;
            VehType = v.VehiclesType.Name;
            Name = v.Member.FirstName;
            ParkedTime = v.ParkedTime;
            Brand = v.Brand;
            Model = v.Model;
            NumberOfWheels = v.NumberOfWheels;
           
        }

        public IndexVehicle(Member member )
        {
            this.member = member;
           
        }
    }
}
