using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_workshop.Models
{
    public class Car(string model, string color, DateOnly upDateYear)
    {

        public string Model { get; set; } = model;
        public DateOnly Year { get; set; } = new DateOnly(2002,5,24);
        public string Color { get; set; } = color;

        public DateOnly UpDateYear { get; set; } = upDateYear;
    }
}