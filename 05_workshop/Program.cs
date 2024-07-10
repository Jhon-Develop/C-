List<int> numbers = new List<int> { 10, 2, 5, 7, 9, 1, 3, 6, -12, -7, -4, 2, -10, 17, 8, 4, 11, 18, 12, 15, 16, 13, 14, 17, 126 };
List<string> strings = new List<string> {"maria", "pedro", "juan", "carla", "nelson", "ana", "daniel", "jhon", "LINQ", "C#", "JavaScript", "Python", "Ruby", "PHP", "Java", "C++", "C", "SQL", "HTML", "CSS", "XML", "ASP", "VB", "Kotlin", "maria", "Scala", "Elixir", "Dart", "maria", "Clojure", "F#", "Antonio", "andrea" };
List<double> doubles = new List<double> {1200.00, 200.00, 900.00, 100.00, 300.00, 600.00, 800.00, 1600.00, 1300.00, 1400.00, 1700.00 };
List<bool> bools = new List<bool> {false, false, false, true, false, true, false, true };
List<byte> ages = new List<byte> {18, 19, 20, 21, 22, 23, 24, 78, 79, 80, 81, 82, 83, 84, 85, 94, 95, 96, 97, 98, 99, 100 };
List<double> Temps = new List<double> {24.4, 32.33, 16.5, 20.0, 19.0};
List<byte> dates = new List<byte> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31};
List<string> citys = new List<string> {"medellin", "bogota", "caracas", "maracaigo", "madrid", "santiago", "valencia", "buenos aires", "lima", "rio de janeiro", "san salvador", "quito", "ottawa" };
List<string> products = new List<string> {"computer", "tv", "phone", "laptop", "tablet", "mouse", "keyboard", "monitor", "printer", "camera", "projector", "headphones", "speakers" };

// 1. Filtra los números mayores a 10 en una lista de enteros.

// var NumBiggest10 = numbers.Where(x => x > 10);
// foreach (var number in NumBiggest10){
//     Console.WriteLine(number);
// }

// 2. Obtén una lista con los cuadrados de cada número en una lista de enteros.

// var Squares = numbers.Select(x => x * x);
// foreach (var number in Squares){
//     Console.WriteLine(number);
// }

// 3. Ordena alfabéticamente una lista de nombres.

// var Alfabetic = strings.OrderBy(x => x);
// foreach (var name in Alfabetic){
//     Console.WriteLine(name);
// }

// 4. Ordena una lista de precios de mayor a menor.

// var Prices = doubles.OrderByDescending(x => x);
// foreach (var price in Prices){
//     Console.WriteLine(price);
// }

// 5. Encuentra el primer número par en una lista de enteros.

// var FirstPar = numbers.Where(x => x % 2 == 0).First();
// Console.WriteLine(FirstPar);

// 6. Encuentra el último nombre en una lista de nombres.

// var LastName = strings.Last();
// Console.WriteLine(LastName);

// 7. Obtén el primer número negativo en una lista de enteros, o un valor por defecto si no hay ninguno.

// var FirstNegative = numbers.Where(x => x < 0).FirstOrDefault();
// Console.WriteLine(FirstNegative);

// 8. Encuentra el último número mayor a 50 en una lista de enteros, o un valor por defecto si no hay ninguno.

// var LastBigger50 = numbers.Where(x => x > 50).LastOrDefault();
// Console.WriteLine(LastBigger50);

// 9. Verifica si algún elemento en una lista de booleanos es verdadero.

// var AnyTrue = bools.Any(x => x);
// Console.WriteLine(AnyTrue);

// 10. Verifica si todos los elementos en una lista de números son mayores a 0.

// var AllBigger0 = numbers.All(x => x > 0);
// Console.WriteLine(AllBigger0);  

// 11. Comprueba si una lista de palabras contiene la palabra "LINQ".

// var ContainsLINQ = strings.Contains("LINQ");
// Console.WriteLine(ContainsLINQ);    

// 12. Cuenta cuántos números pares hay en una lista de enteros.

// var NumOfPairs = numbers.Where(x => x % 2 == 0).Count();
// Console.WriteLine(NumOfPairs);

// 13. Calcula la suma de los elementos en una lista de precios.

// var SumOfPrices = doubles.Sum();
// Console.WriteLine(SumOfPrices);

// 14. Calcula el promedio de una lista de edades.

// var AverageAge = ages.Average(x => x);
// Console.WriteLine(AverageAge);

// 15. Encuentra el número mínimo en una lista de temperaturas.

// var MinTemp = Temps.Min();
// Console.WriteLine(MinTemp);

// 16. Encuentra el número máximo en una lista de alturas.

// var MaxHeight = numbers.Max();
// Console.WriteLine(MaxHeight);

// 17. Obtén los primeros 5 elementos de una lista de puntuaciones.

// var First5Scores = numbers.Take(5);
// foreach (var score in First5Scores){
//     Console.WriteLine(score);
// }

// 18. Salta los primeros 3 elementos de una lista de nombres y obtén los siguientes.

// var SkipNames = strings.Skip(3).ToList();
// foreach (var name in SkipNames){
//     Console.WriteLine(name);
// }

// 19. Elimina los elementos duplicados en una lista de números.

// var DeleteDuplicates = numbers.Distinct().ToList();
// foreach (var number in DeleteDuplicates){
//     Console.WriteLine(number);
// }

// 20. Convierte una lista de palabras en una lista.

// var WordsList = strings.ToList();
// foreach (var word in WordsList){
//     Console.WriteLine(word);
// }

// 21. Convierte una lista de números en un array.

// var NumbersArray = numbers.ToArray();
// foreach (var number in NumbersArray){
//     Console.WriteLine(number);
// }

// 22. Filtra los números negativos de una lista y ordénalos de menor a mayor.

// var NegativeNumbers = numbers.Where(x => x < 0).OrderByDescending(x => x);
// foreach (var number in NegativeNumbers){
//     Console.WriteLine(number);
// }

// 23. Obtén una lista de longitudes de cada palabra en una lista de palabras.

// var LongWords = strings.Select(x => x.Length).ToList();
// foreach (var length in LongWords){
//     Console.WriteLine(length);
// }

// 24. Ordena una lista de salarios de menor a mayor y obtén los 3 más bajos.

// var LowSalaries = doubles.OrderBy(x => x).Take(3);
// foreach (var salary in LowSalaries){
//     Console.WriteLine(salary);
// }

// 25. Obtén los nombres más largos en una lista de nombres.

// var LongNames = strings.Where(x => x.Length > 10);
// foreach (var name in LongNames){
//     Console.WriteLine(name);
// }

// 26. Encuentra el primer número mayor a 100 en una lista de precios.

// var FirstBigger100 = numbers.Where(x => x > 100).First();
// Console.WriteLine(FirstBigger100);

// 27. Encuentra el último día del mes en una lista de fechas.

// var LastDate = dates.Max();
// Console.WriteLine(LastDate);

// 28. Obtén el primer nombre que empieza con 'A' en una lista de nombres o un valor por defecto si no hay ninguno.

// var FirstName = strings.Where(x => x.StartsWith("A")).FirstOrDefault();
// Console.WriteLine(FirstName);

// 29. Encuentra el último número impar en una lista de enteros o un valor por defecto si no hay ninguno.

// var LastOdd = numbers.Where(x => x % 2 == 1).LastOrDefault();
// Console.WriteLine(LastOdd);

// 30. Verifica si alguna palabra en una lista de palabras tiene más de 10 caracteres.

// var LongWords = strings.Where(x => x.Length > 10);
// Console.WriteLine(LongWords.Any());

// 31. Verifica si todas las edades en una lista son mayores de 18.

// var AllBigger18 = ages.All(x => x > 18);
// Console.WriteLine(AllBigger18);

// 32. Comprueba si una lista de ciudades contiene la ciudad "Madrid".

// var Madrid = citys.Contains("madrid");
// Console.WriteLine(Madrid);

// 33. Cuenta cuántos números mayores a 50 hay en una lista de puntuaciones.

// var NumOf50 = numbers.Where(x => x > 50).Count();
// Console.WriteLine(NumOf50);

// 34. Calcula la suma de los números positivos en una lista de enteros.

// var SumOfPositives = numbers.Where(x => x > 0).Sum();
// Console.WriteLine(SumOfPositives);

// 35. Calcula el promedio de las calificaciones en una lista de calificaciones.

// var AverageScore = numbers.Average();
// Console.WriteLine(AverageScore);

// 36. Encuentra la temperatura mínima en una lista de temperaturas.

// var MinTemp = Temps.Min();
// Console.WriteLine(MinTemp);

// 37. Encuentra la altura máxima en una lista de alturas.

// var MaxHeight = numbers.Max();
// Console.WriteLine(MaxHeight);

// 38. Obtén los primeros 10 elementos de una lista de productos.

// var First10Products = products.Take(10);
// foreach (var product in First10Products){
//     Console.WriteLine(product);
// }

// 39. Salta los primeros 5 elementos de una lista de palabras y obtén los siguientes.

// var SkipNames = strings.Skip(5).ToList();
// foreach (var name in SkipNames){
//     Console.WriteLine(name);
// }

// 40. Elimina los elementos duplicados en una lista de nombres y ordénalos alfabéticamente.

// var DeleteDuplicates = strings.Distinct().ToList();
// foreach (var name in DeleteDuplicates){
//     Console.WriteLine(name);
// }