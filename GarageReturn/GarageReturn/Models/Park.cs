using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GarageReturn.Models
{
    public class Park

    {
     public int vehiclesTypeId;

        public Park()
        {
        }

        public Park(string brand, string color, string model, DateTime parkedTime, string regNum, int numberOfWheels, int vehiclesTypeId, int memberId)
        {
            Brand = brand;
            Color = color;
            Model = model;
            ParkedTime = parkedTime;
            RegNum = regNum;
            NumberOfWheels = numberOfWheels;
            this.vehiclesTypeId = vehiclesTypeId;
            MemberId = memberId;
        }

        public int Id { get; set; }

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

        public int MemberId { get; set; }
        public int VehicleTypesId { get; set; }
        public DateTime ParkedTime { get; set; }

        public IEnumerable<SelectListItem> ListMembers { get; set; }
        public IEnumerable<SelectListItem> ListVehicleTypes { get; set; }
  
    }
}