using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageReturn.Models
{
    public class ReceiptViewModel
    {
        public DateTime now;
       public decimal v;

        public ReceiptViewModel(int id, string regNum, DateTime now, DateTime parkedTime, decimal v)
        {
            Id = id;
            RegNum = regNum;
            this.now = now;
            ParkedTime = parkedTime;
            this.v = v;
        }

        public ReceiptViewModel(int id, string regNum, string vehicleType, DateTime time, DateTime parkedTime, decimal price)
        {
            Id = id;
            RegNum = regNum;
            VehicleType = vehicleType;
            Time = time;
            ParkedTime = parkedTime;
            Price = price;
        }

        public int Id { get; set; }
        public string RegNum { get; set; }
        public string VehicleType { get; set; }
        public DateTime Time { get; set; }
        public DateTime ParkedTime { get; set; }
        public decimal Price { get; set; }
    }
}
 