using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageReturn.Models
{
    public class VehiclesViewModel
    {
        private DateTime now;

        public VehiclesViewModel(int id, string regNum, DateTime now, DateTime parkedTime)
        {
            Id = id;
            RegNum = regNum;
            this.now = now;
            ParkedTime = parkedTime;
        }

        public VehiclesViewModel(int id, string regNum, string vehicleType, DateTime time, DateTime parkedTime)
        {
            Id = id;
            RegNum = regNum;
            VehicleType = vehicleType;
            Time = time;
            ParkedTime = parkedTime;
         
        }

        public int Id { get; set; }
        public string RegNum { get; set; }
        public string VehicleType { get; set; }
        public DateTime Time { get; set; }
        public DateTime ParkedTime { get; set; }
        
    }

  
} 