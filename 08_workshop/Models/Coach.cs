using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _08_workshop.Models
{
    public class Coach(byte experience, byte numberTitles, double salary, string nationality)
    {
        public byte Experience { get; set;} = experience;
        public byte NumberTitles { get; set;} = numberTitles;
        private double Salary { get; set;} = salary;
        public string Nationality { get; set;} = nationality;

    }
}

