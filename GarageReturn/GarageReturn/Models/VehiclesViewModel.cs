using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageReturn.Models
{
    public class VehiclesViewModel
    {
        
        
        public VehiclesViewModel(int id, string regNum, string vehicleType, DateTime parkedTime, DateTime nowTime )
        {
            Id = id;
            RegNum = regNum;
            VehicleType = vehicleType;
            NowTime = nowTime;
            ParkedTime = parkedTime;
            //FirstName = firstName;



        }


        //public VehiclesViewModel(Member member)
        //{
        //    this.member = member;

        //}

        public int Id { get; set; }
        public string RegNum { get; set; }
        public string VehicleType { get; set; }
        public DateTime NowTime { get; set; }
        public DateTime ParkedTime { get; set; }
        public string FirstName { get; set; }
        //public Member member;

    }
    


} 