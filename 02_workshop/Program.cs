/*
1. Escribe un programa que pida al usuario un número y muestre si es par o impar usando
una condición if.
*/

// Console.Write("Ingrese un numero => ");
// int numero = Convert.ToInt32(Console.ReadLine());
// if (numero % 2 == 0)
// {
// Console.WriteLine("El numero es par");
// }
// else
// {
// Console.WriteLine("El numero es impar");
// }

/*
2. Escribe un programa que pida al usuario que ingrese su nombre. Luego, verifica si el
nombre ingresado no es nulo ni está vacío. Si el nombre es válido, muestra un mensaje de
bienvenida; de lo contrario, muestra un mensaje de error.
*/

// Console.Write("Ingrese su nombre => ");
// string? name = Console.ReadLine();

// if (string.IsNullOrEmpty(name))
// {
//     Console.WriteLine("El nombre no puede estar en blanco");
// }else
// {
//     Console.WriteLine("Bienvenido " + name);
// }

/*
3. Escribe un programa que pida al usuario su edad y muestre si es mayor o menor de edad
usando if-else.
*/

// Console.Write("Ingrese su edad => ");
// byte age = Convert.ToByte(Console.ReadLine());

// if (age >= 18)
// {
//     Console.WriteLine("Eres mayor de edad");
// }else
// {
//     Console.WriteLine("Eres menor de edad");
// }

/*
4. Escribe un programa que pida al usuario un día de la semana (como número del 1 al 7) y
muestre el nombre del día correspondiente usando switch.
*/

// Console.Write("Ingrese el numero del día de la semana => ");
// int day = Convert.ToInt32(Console.ReadLine());
// switch (day)
// {
//     case 1:
//         Console.WriteLine("Lunes");
//         break;
//     case 2:
//         Console.WriteLine("Martes");
//         break;
//     case 3:
//         Console.WriteLine("Miércoles");
//         break;
//     case 4:
//         Console.WriteLine("Jueves");
//         break;
//     case 5:
//         Console.WriteLine("Viernes");
//         break;
//     case 6:
//         Console.WriteLine("Sábado");
//         break;
//     case 7:
//         Console.WriteLine("Domingo");
//         break;
//     default:
//         Console.WriteLine("El día no es válido");
//         break;
// }

/*
5. Escribe un programa que pida al usuario su equipo de nacionalidad, si es colombiana debe
decirle que es nativo el país y si no lo es debe decir que es extranjeto (hacer ejercicio con
operador ternario).
*/

// Console.Write("Ingrese su nacionalidad => ");
// string? nationality = Console.ReadLine();

// if (nationality == "Colombia")
// {
//     Console.WriteLine("Es nativo del país");
// }
// else
// {
//     Console.WriteLine("Es extranjero");
// };

/*
6. Escribe un programa que pida al usuario tres números y muestre cuál es el mayor usando
if-else.
*/

// Console.Write("Ingrese tres números => ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2 && num1 > num3)
// {
//     Console.WriteLine(num1 + " es el mayor");
// }
// else if (num2 > num1 && num2 > num3)
// {
//     Console.WriteLine(num2 + " es el mayor");
// }
// else
// {
//     Console.WriteLine(num3 + " es el mayor");
// }

/*
7. Escribe un programa que pida al usuario que ingrese una contraseña. Verifica si la
contraseña no es nula ni está vacía. Si la contraseña es válida, muestra un mensaje
indicando que la contraseña es aceptada; de lo contrario, muestra un mensaje indicando
que la contraseña no puede estar en blanco.
*/

// Console.Write("Ingrese su contraseña => ");
// string? password = Console.ReadLine();

// if (string.IsNullOrEmpty(password))
// {
//     Console.WriteLine("La contraseña no puede estar en blanco");
// }
// else
// {
//     Console.WriteLine("La contraseña es aceptada");
// };

/*
8. Escribe un programa que pida al usuario un número del 1 al 12 y muestre el nombre del
mes correspondiente usando switch.
*/

// Console.Write("Ingrese el número del mes => ");
// int month = Convert.ToInt32(Console.ReadLine());
// switch (month)
// {
//     case 1:
//         Console.WriteLine("Enero");
//         break;
//     case 2:
//         Console.WriteLine("Febrero");
//         break;
//     case 3:
//         Console.WriteLine("Marzo");
//         break;
//     case 4:
//         Console.WriteLine("Abril");
//         break;
//     case 5:
//         Console.WriteLine("Mayo");
//         break;
//     case 6:
//         Console.WriteLine("Junio");
//         break;
//     case 7:
//         Console.WriteLine("Julio");
//         break;
//     case 8:
//         Console.WriteLine("Agosto");
//         break;
//     case 9:
//         Console.WriteLine("Septiembre");
//         break;
//     case 10:
//         Console.WriteLine("Octubre");
//         break;
//     case 11:
//         Console.WriteLine("Noviembre");
//         break;
//     case 12:
//         Console.WriteLine("Diciembre");
//         break;
//     default:
//         Console.WriteLine("El mes no es válido");
//         break;
// };

/*
9. Escribe un programa que pida al usuario una calificación numérica y muestre la letra
correspondiente (A, B, C, D, F) usando if-else.
*/

// Console.Write("Ingrese su calificación => ");
// int score = Convert.ToInt32(Console.ReadLine());

// if (score >= 90)
// {
//     Console.WriteLine("A");
// }
// else if (score >= 80)
// {
//     Console.WriteLine("B");
// }
// else if (score >= 70)
// {
//     Console.WriteLine("C");
// }
// else if (score >= 60)
// {
//     Console.WriteLine("D");
// }
// else
// {
//     Console.WriteLine("F");
// };

/*
10. Escribe un programa que pida al usuario un carácter y determine si es una vocal o una
consonante usando switch.
*/

// Console.Write("Ingrese un carácter => ");
// string? letter = Console.ReadLine();

// if (string.IsNullOrEmpty(letter) || letter.Length > 1)
// {
//     Console.WriteLine("El carácter no puede estar en blanco");
// }
// else
// {
//     char vocal = Convert.ToChar(letter.ToLower());

//     switch (vocal)
//     {
//         case 'a':
//         case 'e':
//         case 'i':
//         case 'o':
//         case 'u':
//             Console.WriteLine("Es una vocal");
//             break;
//         default:
//             Console.WriteLine("Es una consonante");
//             break;
//     };
// }

/*
11. Escribe un programa que pida al usuario dos números y muestre si son iguales o diferentes
usando if-else.
*/

// Console.Write("Ingrese dos números => ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == num2)
// {
//     Console.WriteLine("Son iguales");
// }
// else
// {
//     Console.WriteLine("Son diferentes");
// };

/*
12. Escribe un programa que solicite al usuario que ingrese su dirección. Verifica si la dirección
no es nula, no está vacía y no consiste sólo en espacios en blanco. Si la dirección es válida,
muestra un mensaje de confirmación; de lo contrario, muestra un mensaje de error.
*/

// Console.Write("Ingrese su dirección => ");
// string? address = Console.ReadLine();

// if (string.IsNullOrEmpty(address) || address.Length == 0)
// {
//     Console.WriteLine("La dirección no puede estar en blanco");
// }
// else
// {
//     Console.WriteLine("La dirección es válida");
// };

/*
13. Escribe un programa que pida al usuario un número y determine si es positivo, negativo o
cero usando if-else. */

// Console.WriteLine("Introduce el numero que desea: ");
// int numero = Convert.ToInt32(Console.ReadLine());

// if (numero == 0){
//     Console.WriteLine("Tu numero es neutro");
// }else if (numero > 0){
//     Console.WriteLine("Tu numero es positivo");
// }else{
//     Console.WriteLine("Tu numero es negativo");
// };

/*
14. Escribe un programa que pida al usuario una letra y determine si es una vocal usando
if-else.
*/

// Console.Write("Introduce una letra => ");
// string? letra = Console.ReadLine();

// if (string.IsNullOrEmpty(letra) || letra.Length > 1)
// {
//     Console.WriteLine("La letra no puede estar en blanco ni sobrepasar un carácter");
// }else
// {
//     char vocal = Convert.ToChar(letra.ToLower());

//     if (vocal == 'a' || vocal == 'e' || vocal == 'i' || vocal == 'o' || vocal == 'u')
//     {
//         Console.WriteLine("Es una vocal");
//     }else
//     {
//         Console.WriteLine("Es una consonante");
//     };
// };

/*
15. Escribe un programa que pida al usuario una temperatura en grados Celsius y determine si
es caliente (mayor a 30), templada (entre 10 y 30) o fría (menor a 10) usando if-else.
*/

// Console.Write("Ingrese su temperatura en grados Celsius => ");
// int temperatura = Convert.ToInt32(Console.ReadLine());

// if (temperatura > 30)
// {
//     Console.WriteLine("Es caliente");
// }
// else if (temperatura >= 10 && temperatura <= 30)
// {
//     Console.WriteLine("Es templada");
// }
// else
// {
//     Console.WriteLine("Es fría");
// };

/*
16. Escribe un programa que pida al usuario un año y determine si es un año bisiesto usando
if-else.
*/

// Console.Write("Ingrese su año => ");
// int year = Convert.ToInt32(Console.ReadLine());

// if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
// {
//     Console.WriteLine("Es un año bisiesto");
// }
// else
// {
//     Console.WriteLine("Es un año no bisiesto");
// };

/*
17. Escribe un programa que pida al usuario que ingrese un valor. Verifica si el valor ingresado
no es nulo, no está vacío y no contiene solo espacios en blanco. Si la entrada es válida,
muestra el valor; de lo contrario, pide al usuario que ingrese un valor válido.
*/

// Console.Write("Ingrese un valor => ");
// string? value = Console.ReadLine();

// if (string.IsNullOrEmpty(value) || value.Length == 0)
// {
//     Console.WriteLine("El valor no puede estar en blanco");
// }
// else
// {
//     Console.WriteLine("El valor es válido");
// };

/*
18. Escribe un programa que pida al usuario un número del 1 al 7 y determine si es un día
laborable o de fin de semana usando switch.
*/

// Console.Write("Ingrese el número del día de la semana => ");
// int day = Convert.ToInt32(Console.ReadLine());

// switch (day)
// {
//     case 1:
//         Console.WriteLine("Lunes");
//         break;
//     case 2:
//         Console.WriteLine("Martes");
//         break;
//     case 3:
//         Console.WriteLine("Miércoles");
//         break;
//     case 4:
//         Console.WriteLine("Jueves");
//         break;
//     case 5:
//         Console.WriteLine("Viernes");
//         break;
//     case 6:
//         Console.WriteLine("Es Sábado no es un día laborable");
//         break;
//     case 7:
//         Console.WriteLine("Es Domingo no es un día laborable");
//         break;
//     default:
//         Console.WriteLine("El día no es válido");
//         break;
// };