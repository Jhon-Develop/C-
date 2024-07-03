// Imprimir "Hola Mundo!"
Console.WriteLine("¡Hola Mundo!");

// Declarar int y string y asignarles valores e imprimirlos
int a = 10;
string b = "Hola Mundo!";
Console.WriteLine(a);
Console.WriteLine(b);

// Convierte string en mayusculas y minusculas
string saludo = "Hola, espero que esten bien";
Console.WriteLine(saludo.ToUpper());
Console.WriteLine(saludo.ToLower());

// Declarar 2 int realizar operaciones basicas
int x = 10;
int y = 20;

int suma = x + y;
int resta = x - y;
int multiplicacion = x * y;
int division = x / y;

Console.WriteLine(@$"Suma: {suma}
resta: {resta}
multiplicacion: {multiplicacion}
division: {division}");

// Declarar 2 int y realizar operaciones de igualdad
int j = 10;
int z = 20;

bool igual = j == z;
bool diferente = j != z;
bool mayor = j > z;
bool menor = j < z;

Console.WriteLine(@$"igual: {igual}
diferente: {diferente}
mayor: {mayor}
menor: {menor}");

// Buscar una palabra y reemplazarla por otra
string palabra = "Hola Mundo!";
Console.WriteLine(palabra);
string sustituto = "Como esta";
palabra = palabra.Replace("Hola", sustituto);
Console.WriteLine(palabra);

// Pedir nombre y edad al usuario e imprimirlos
Console.WriteLine("Introduzca su nombre: ");
string? nombre = Console.ReadLine();
Console.WriteLine("Introduzca su edad: ");
string? edad = Console.ReadLine();
Console.WriteLine(@$"Hola, {nombre} tienes {edad} años es increible!");

// declarar un programa si diga que es mayor que 10
int num = 10;

if (num == 10)
{
    Console.WriteLine("Es igual a 10");
}else if(num > 10){
    Console.WriteLine("Es mayor que 10");
}else{
    Console.WriteLine("es menor que 10");
};

// declarar 2 doubles y realizar operaciones
double f = 10.5;
double g = 20.5;

double sum = f + g;
double rest = f - g;
double mult = f * g;
double div = f / g;

Console.WriteLine(@$"Suma: {sum}
resta: {rest}
multiplicacion: {mult}
division: {div}");

// declarar 2 strigns y concatenarlas
string cadena1 = "Hola ";
string cadena2 = "Mundo!";
string cadena3 = cadena1 + cadena2;
Console.WriteLine(cadena3);

// declara una variable int convertir a double
int entero = 10;
Console.WriteLine(entero);
double decimals = a + 0.5;
Console.WriteLine(decimals);

// Hacer programa que indique si es positivo o negativo
Console.WriteLine("Introduce el numero que desea: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero == 0){
    Console.WriteLine("Tu numero es neutro");
}else if (numero > 0){
    Console.WriteLine("Tu numero es positivo");
}else{
    Console.WriteLine("Tu numero es negativo");
};

//bucle for ppara imprimir numeros de 1 a 10
for (int i = 0; i < 11; i++){
    Console.WriteLine(i);
}

// Eliminar espacios en blanco y primera mayuscula y el resto minuscula
string  texto = " este texto debe comenzar con la primera en mayuscula y sin espacios ";

texto = texto.Trim();

if(!string.IsNullOrEmpty(texto)){
    texto = texto.Substring(0, 1).ToUpper() + texto.Substring(1).ToLower();
}


Console.WriteLine(texto);

//Escribir un programa que solicite un numero y muestre su tabla de multiplicar del 1 al 10
Console.WriteLine("Introduzca un numero");
int tabla = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++){
    Console.WriteLine($"{tabla} x {i} = {i * tabla}");
}

// Concatena 2 strings y muestra la logitud de cada uno
string combinacion1 = "Hola ", combinacion2 = "Mundo!";
string combinacion = combinacion1 + combinacion2;
Console.WriteLine($"Longitud primera cadena: {combinacion1.Length}, longitud segunda cadena: {combinacion2.Length}, combinacion de ambas cadenas: {combinacion}");


//Extrae una subcadena de un string y muestrala junto a su longitud
string[] strings = { "Hola", "Mundo", "Como", "estas", "?" };
Console.WriteLine($"Introduzca el índice de la subcadena que desea extraer (0 a {strings.Length - 1}): ");
if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < strings.Length)
{
    string subcadena = strings[indice];
    Console.WriteLine($"La palabra '{subcadena}' tiene longitud {subcadena.Length}");
}
else
{
    Console.WriteLine("Índice no válido. Por favor, introduzca un número entre 0 y " + (strings.Length - 1));
};