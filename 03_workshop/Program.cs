/* 1. Escribe un programa que imprima los números del 1 al 100 usando un ciclo for.*/

// for (int i = 0; i < 100; i++)
// {
//     Console.WriteLine($"Repeticion {i + 1}");
// }

/* 2. Escribe un programa que solicite al usuario un número entero positivo e imprima todos los
números pares desde 1 hasta ese número usando un ciclo for. */

// Console.Write("Ingrese un numero entero positivo => ");
// int numero = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i < numero; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.Write("Los numeros pares son:");
//         Console.WriteLine($"{i}");
//     }
// }

/*3. Escribe un programa que pida al usuario un número entero positivo e imprima la tabla de
multiplicar de ese número del 1 al 10 usando un ciclo for.*/

// Console.Write("Introduzca un numero entero positivo => ");
// int tabla = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= 10; i++){
//     Console.WriteLine($"{tabla} x {i} = {i * tabla}");
// }

/*4. Escribe un programa que genere un número aleatorio entre 1 y 100. Pídele al usuario que
adivine el número. Muestra un mensaje indicando si el número ingresado es demasiado
alto, demasiado bajo o correcto. Continúa pidiendo al usuario que adivine hasta que
adivine correctamente usando un ciclo do-while.*/

// Random random = new Random();
// int aleatorio = random.Next(0, 100);

// Console.Write("Introduzca un numero entero positivo entre (1 - 100)=> ");

// int numero = 0;
// bool acertado = false;


// do
// {
//     numero = Convert.ToInt32(Console.ReadLine());
//     if (numero < aleatorio)
//     {
//         Console.WriteLine("El número aleatorio es mayor que el ingresado");
//         Console.Write("Ingresa otro numero entre (1 - 100)=> ");
//     }
//     else if (numero > aleatorio)
//     {
//         Console.WriteLine("El número aleatorio es menor que el ingresado");
//         Console.Write("Ingresa otro numero entre (1 - 100)=> ");
//     }
//     else
//     {
//         acertado = true;
//     }
// } while (!acertado);
//     Console.WriteLine("El número que ingresaste es el correcto !Felicidades 🍻¡");

/*5. Escribe un programa que solicite al usuario un número entero positivo e imprima todos los
números impares desde ese número hasta 1 usando un ciclo while.*/

// Console.Write("Introduce un numero entero positivo => ");
// int numero = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < numero; i++)
// {
//     if (i % 2 != 0)
//     {
//         Console.WriteLine($"El numero {i} es impar");
//     }
// }

/* 6. Escribe un programa que solicite al usuario una contraseña. Si la contraseña ingresada no
es "secreta", sigue pidiendo al usuario que ingrese la contraseña hasta que sea correcta
usando un ciclo while.*/

// while (true){
//     Console.Write("Introduce una contraseña => ");
//     string? password = Console.ReadLine();

//     if (password == "secreta")
//     {
//         Console.WriteLine("La contraseña es correcta");
//         break;
//     }else{
//         Console.WriteLine("La contraseña es incorrecta");
//     }
// }

/*7. Escribe un programa que solicite al usuario un número entero positivo e imprima la
secuencia de Fibonacci hasta ese número usando un ciclo for.*/

/* Forma de hacer la secuencia de fibonacci usando el siclo for imprimiendo la cantidad que el usuario ingrese */

// Console.Write("Ingresa un número entero positivo: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int[] fibonacci = new int[number];

// fibonacci[0] = 0;
// fibonacci[1] = 1;

// for (int i = 2; i < number; i++)
// {
//     fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
// }

// for (int i = 0; i < number; i++)
// {
//     Console.WriteLine($"El {i + 1}º elemento de la secuencia de Fibonacci es {fibonacci[i]}");
// }

// Console.Write("Ingresa un número entero positivo: ");
// int number = Convert.ToInt32(Console.ReadLine());

// List<int> fibonacci = new List<int>() { 0, 1 };

// for (int i = 2; i <= number; i++)
// {
//     if (fibonacci[i - 1] + fibonacci[i - 2] > number) break;
//     fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);

// }

// for (int i = 0; i < fibonacci.Count; i++)
// {
//     Console.WriteLine($"El {i + 1}º elemento de la secuencia de Fibonacci es {fibonacci[i]}");
// }

/* 8. Escribe un programa que solicite al usuario un número entero positivo e imprima si el
número es primo o no usando un ciclo for.*/

// Console.Write("Ingresa un número entero positivo: ");
// int number = Convert.ToInt32(Console.ReadLine());

// bool primo = false;

// for (int i = 2; i <= number / 2; i++)
// {
//     if (number == 1)
//     {
//         primo = false;
//         break;
//     }else if (number % i == 0)
//     {
//         primo = false;
//         break;
//     }else
//     {
//         primo = true;
//     }
// }
// Console.WriteLine(primo ? "El número es primo" : "El número no es primo");

/*9. Escribe un programa que solicite al usuario una palabra y luego imprima cada letra de la
palabra en una línea separada usando un ciclo foreach.*/

// Console.Write("Ingresa una palabra: ");
// string? palabra = Console.ReadLine();

// foreach (char letra in palabra)
// {
//     Console.WriteLine(letra);
// }

/* 10. Escribe un programa que solicite al usuario un número entero positivo e imprima la suma
de todos los números desde 1 hasta ese número usando un ciclo for.*/

// Console.Write("Ingresa un número entero positivo: ");
// int numero = Convert.ToInt32(Console.ReadLine());

// int suma = 0;

// for (int i = 1; i <= numero; i++)
// {
//     suma += i;
// }

// Console.WriteLine($"La suma de los números desde 1 hasta {numero} es {suma}");

/* 11. Escribe un programa que solicite al usuario un número entero positivo e imprima la
suma de los números pares desde 1 hasta ese número usando un ciclo for.*/

// Console.Write("Ingresa un número entero positivo: ");
// int numero = Convert.ToInt32(Console.ReadLine());

// int suma = 0;

// for (int i = 1; i <= numero; i++)
// {
//     if (i % 2 == 0)
//     {
//         suma += i;
//     }
// }
// Console.WriteLine($"La suma de los números pares desde 1 hasta {numero} es {suma}");

/* 12. Escribe un programa que solicite al usuario un número entero positivo e imprima la
suma de los números impares desde 1 hasta ese número usando un ciclo for.*/

// Console.Write("Ingresa un número entero positivo: ");
// int numero = Convert.ToInt32(Console.ReadLine());

// int suma = 0;

// for (int i = 1; i <= numero; i++)
// {
//     if (i % 2 != 0)
//     {
//         suma += i;
//     }
// }
// Console.WriteLine($"La suma de los números impares desde 1 hasta {numero} es {suma}");