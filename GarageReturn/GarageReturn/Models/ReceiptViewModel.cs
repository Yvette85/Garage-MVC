using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageReturn.Models
{
    public class ReceiptViewModel
    {
        public ReceiptViewModel(int id, string regNum, VehiclesTypes vehicleType, DateTime time, DateTime parkedTime, decimal price)
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
        public VehiclesTypes VehicleType { get; set; }
        public DateTime Time { get; set; }
        public DateTime ParkedTime { get; set; }
        public decimal Price { get; set; }
    }
}
