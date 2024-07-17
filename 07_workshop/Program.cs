using _07_workshop.Models;

// Create a new instance of the Persona class

// Console.Write("Enter your name: ");
// string name = Console.ReadLine().ToLower();
// Console.Write("Enter your age: ");
// int age = int.Parse(Console.ReadLine());



// var person = new Persona(name, age);
// person.Greet();

// Create a new instance of the Car class
var car = new Car("Toyota", "Rojo", new DateOnly(2022,6,14));
Console.WriteLine($"Modelo: {car.Model}, Color: {car.Color}, Año de fabricación: {car.Year}");