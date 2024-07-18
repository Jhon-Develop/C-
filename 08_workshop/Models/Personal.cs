using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _08_workshop.Models
{
    public class Personal(int id, string name, string lastName,string documentType, string documentNumber, DateOnly bornDate, string rh, string topSize, string lowerWaist, double shoeSize)
    {
        private int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string LastName { get; set; } = lastName;
        public string DocumentType { get; set;} = documentType;
        public string DocumentNumber { get; set;} = documentNumber;
        public DateOnly BornDate { get; set;} = bornDate;
        protected string Rh { get; set;} = rh;
        public string TopSize { get; set;} = topSize;
        public string LowerWaist { get; set;} = lowerWaist;
        public double ShoeSize { get; set;} = shoeSize;

        public int CalculateAge()
        {
            int age = DateTime.Now.Year - BornDate.Year;
            return age;
        }

        public void DatesShow()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"LastName: {LastName}");
            Console.WriteLine($"DocumentType: {DocumentType}");
            Console.WriteLine($"DocumentNumber: {DocumentNumber}");
            Console.WriteLine($"BornDate: {BornDate}");
            Console.WriteLine($"Rh: {Rh}");
            Console.WriteLine($"TopSize: {TopSize}");
            Console.WriteLine($"LowerWaist: {LowerWaist}");
            Console.WriteLine($"ShoeSize: {ShoeSize}");
        }

        internal bool DatesShow(string name, string lastName, string documentType, string documentNumber, DateOnly bornDate, string rh, string topSize, string lowerWaist, double shoeSize)
        {
            throw new NotImplementedException();
        }
    }
}