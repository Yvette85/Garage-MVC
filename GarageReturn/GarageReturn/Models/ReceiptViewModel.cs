using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GarageReturn.Models
{
    public class ReceiptViewModel
    {
      
    

        public ReceiptViewModel(int id, string regNum, string vehicleType, DateTime parkedTime, DateTime nowTime, string name)
        {
            Id = id;
            RegNum = regNum;
            VehicleType = vehicleType;
            NowTime = nowTime;
            Name = name;

            ParkedTime = parkedTime;
            TimeSpan ts = NowTime - ParkedTime;
            TotalTime = $"{Math.Floor(ts.TotalDays)} days, {ts.Hours} hours and {ts.Minutes} minutes.";
               Price = (ts.TotalMinutes ) * 5;
  
       
        }

        public ReceiptViewModel(Member member)
        {
            this.member = member;

        }


     

        public int Id { get; set; }

        public string RegNum { get; set; }

        public string VehicleType { get; set; }

        [Display(Name = "Check out time")]
        [UIHint("DateFormat")]


        public DateTime NowTime { get; set; }

        [Display(Name = "Arrival time")]
        [UIHint("DateFormat")]
        public DateTime ParkedTime { get; set; }

        public double Price { get; set; }

        [Display(Name = "Total time")]
        public string TotalTime { get; set; }
        public Member member;
        public string Name;


    }
    
}


