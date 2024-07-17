using _08_workshop.Models;

Console.Clear();

Console.Write("Ingresa tu nombre => ");
string nombre = Console.ReadLine().ToLower();

Console.Write("Ingresa tu edad => ");
int edad = int.Parse(Console.ReadLine());

Console.Write($"Hola {nombre} con la edad de {edad} años espero que te encuentres bien");

var persona = new Person(nombre, edad);
Console.WriteLine(persona.SayHello());