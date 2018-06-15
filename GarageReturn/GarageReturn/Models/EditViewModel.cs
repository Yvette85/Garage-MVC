using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageReturn.Models
{
    public class EditViewModel
    {

        public EditViewModel()
        {

        }
        public EditViewModel(int id, string color, string brand, string model, int numberOfWheels , string regNum)
        {
             Id  = id;
            Color= color;
            Brand = brand;
            Model = model;
            NumberOfWheels = numberOfWheels;
            RegNum = regNum;
        }

        public int Id { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
        public string RegNum { get; set; }
    }
   
}