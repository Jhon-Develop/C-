using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_workshop.Models
{
    public class Persona (string name, int age)
    {
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;

        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }
}