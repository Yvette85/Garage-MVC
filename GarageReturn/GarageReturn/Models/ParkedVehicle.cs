﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GarageReturn.Models
{
    public class ParkedVehicle
    {

        public int Id { get; set; }

        //[Required (ErrorMessage = "Vehicle type is required")]
        //public VehiclesTypes VehicleTypes { get; set; }

        [Required(ErrorMessage = "Please , specify the Registration number")]
        public string RegNum { get; set; }

        [Required(ErrorMessage = "Please , specify the color of the vehicle")]

        public string Color { get; set; }

        [Required(ErrorMessage = "Please , specify the brand of the vehicle")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Please , specify the model")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Please , specify the number of wheels")]
        public int NumberOfWheels { get; set; }

      
        public DateTime ParkedTime { get; set; }


        public int MemberId { get; set; }

        public virtual Member Member { get; set; }

        public int VehiclesTypeId { get; set; }

        public virtual VehicleType VehiclesType { get; set; }



    }
    //public enum VehiclesTypes
    //{
    //    Bus,
    //    Car,
    //    Motorcycle,
    //    Truck
    //}

}