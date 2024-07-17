using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace _08_workshop.Models
{
    public class Person(string name, int age)
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;

        public string SayHello()
        {
            return$"Hola {Name} con la edad de {Age} años espero que te encuentres bien";
        }
    }
}