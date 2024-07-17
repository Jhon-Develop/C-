namespace analyti_sales;

public class Program
{
    public static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new("Laptop Dell XPS 13", 1200.00m, 24),
            new("Smartphone Samsung Galaxy S21", 999.99m, 12),
            new("Tablet Apple iPad Pro", 899.00m, 12),
            new("Monitor LG UltraWide 34\"", 450.00m, 24),
            new("Teclado Mecánico Corsair", 150.00m, 12),
            new("Mouse Logitech MX Master 3", 100.00m, 24),
            new("Disco Duro Externo Seagate 2TB", 80.00m, 24),
            new("SSD Samsung 970 EVO 1TB", 150.00m, 36),
            new("Auriculares Sony WH-1000XM4", 350.00m, 12),
            new("Smartwatch Apple Watch Series 6", 399.00m, 12),
            new("Impresora HP Envy 6055", 130.00m, 12),
            new("Router TP-Link Archer AX6000", 300.00m, 24),
            new("Cámara Canon EOS M50", 650.00m, 24),
            new("Micrófono Blue Yeti", 120.00m, 12),
            new("Proyector Epson Home Cinema", 700.00m, 36),
            new("Consola Nintendo Switch", 299.00m, 12),
            new("Altavoz Bluetooth JBL Charge 4", 150.00m, 12),
            new("Drone DJI Mavic Air 2", 799.00m, 12),
            new("Smart TV Samsung 55\" 4K", 600.00m, 24),
            new("Cámara de Seguridad Nest Cam", 200.00m, 12)
        };

        List<Sale> sales = new List<Sale>();


        const int maxWidth = 95;

        static decimal InputDecimal(string prompt)
        {
            Console.Write(prompt);
            decimal input;
            while (!decimal.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Por favor, ingresa un valor válido.");
                Console.Write(prompt);
            }
            return input;
        }

        static int InputInt(string prompt)
        {
            Console.Write(prompt);
            int input;
            while (!int.TryParse((Console.ReadLine() ?? string.Empty).AsSpan(), out input))
            {
                Console.WriteLine("Por favor, ingresa un valor entero");
                Console.Write(prompt);
            }
            return input;
        };

        static DateTime InputDate(string prompt)
        {
            Console.Write(prompt);
            DateTime input;
            while (!DateTime.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Por favor, ingresa una fecha válida:");
                Console.Write(prompt);
            }
            return input;
        }
        // static double InputDouble(string prompt)
        // {
        //     Console.Write(prompt);
        //     double input;
        //     while (!double.TryParse((Console.ReadLine() ?? string.Empty).AsSpan(), out input))
        //     {
        //         Console.WriteLine("Por favor, ingresa un valor numérico");
        //         Console.Write(prompt);
        //     }
        //     return input;
        // };

        static string InputString(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            return input;
        };

        static string Header(string title)

        {
            string LineSeprator = new('#', maxWidth);

            var titleLength = title.Length % 2 == 0 ? title.Length : title.Length + 1;
            var paddedTitle = title.PadLeft(titleLength, ' ');

            var spacesCount = (maxWidth - titleLength) / 2 - 1;
            string spaceInTitle = new(' ', spacesCount);

            string titleLine = $"#{spaceInTitle}{paddedTitle}{spaceInTitle}#";
            string header = $"{LineSeprator}\n{titleLine}\n{LineSeprator}";

            return header;
        }

        static void ClientMonth(List<Sale> sales)
        {
            Console.Write("Ingrese el número del mes (1-12): ");
            int month;
            while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
            {
                Console.WriteLine("Por favor, ingrese un número de mes válido (1-12).");
                Console.Write("Ingrese el número del mes (1-12): ");
            }

            var salesInMonth = sales.Where(sale => sale.Date.Month == month).ToList();

            if (salesInMonth.Count == 0)
            {
                Console.WriteLine("No se encontraron ventas para el mes seleccionado.");
                return;
            }

            var clientGroups = salesInMonth.GroupBy(sale => sale.Buyer).OrderByDescending(group => group.Count()).FirstOrDefault();

            if (clientGroups == null)
            {
                Console.WriteLine("No se encontró ningún cliente con ventas en el mes seleccionado.");
                return;
            }

            var client = clientGroups.Key;
            var clientSales = clientGroups.ToList();

            var monthName = new DateTime(1, month, 1).ToString("MMMM");

            Console.WriteLine($"El cliente del mes de {monthName} es {client.Name} con {clientSales.Count} compras:");

            string productLineSeparator = new('-', 90);
            Console.WriteLine($"{"Nro",-4} | {"Date",-12} | {"Seller",-14} | {"Products",-5}");
            Console.WriteLine(productLineSeparator);

            int saleNumber = 1;
            foreach (var sale in clientSales)
            {
                Console.WriteLine($"{saleNumber,-4} | {sale.Date.ToShortDateString(),-12} | {sale.Seller.Name,-14}");

                foreach (var product in sale.Products)
                {
                    Console.WriteLine($"{new string(' ', 34)} - {product.Name,-25} {product.Price,10:C}");
                }

                Console.WriteLine(productLineSeparator);
                saleNumber++;
            }
        };

        static void BestClients(List<Sale> sales)
        {
            var salesGroupedByMonth = sales.GroupBy(sale => sale.Date.Month);

            foreach (var monthGroup in salesGroupedByMonth)
            {
                var month = monthGroup.Key;
                var monthName = new DateTime(1, month, 1).ToString("MMMM");

                var bestClientGroup = monthGroup.GroupBy(sale => sale.Buyer).OrderByDescending(group => group.Count()).FirstOrDefault();

                if (bestClientGroup != null)
                {
                    var bestClient = bestClientGroup.Key;
                    var numberOfSales = bestClientGroup.Count();

                    Console.WriteLine($"El mejor cliente de {monthName} es {bestClient.Name} con {numberOfSales} ventas.");
                }
                else
                {
                    Console.WriteLine($"No se encontraron ventas para {monthName}.");
                }
            }
        }

        static void ClientSales(List<Sale> sales)
        {
            Console.WriteLine("Sales made to clients");
        };

        static void RecordSales(List<Product> products, List<Sale> sales)
        {
            ShowProducts(products);
            List<Product> productsToSell = new List<Product>();

            string saleProducts = InputString("Enter your number of products followed by a comma ',' => ");
            var SaleProductIndex = saleProducts.Split(',', ' ').Select(int.Parse).ToList();

            string newClient = InputString("Enter the fullname of the new client => ");
            string newEmployee = InputString("Enter the name of the new employee => ");
            DateTime newTime = InputDate("Enter the time of the new sale (MM/DD/YYYY) => ");


            foreach (var product in SaleProductIndex)
            {
                int indexProduct = product - 1;
                var Saleproduct = products[indexProduct];
                productsToSell.Add(Saleproduct);
                Console.WriteLine($"{Saleproduct.Name,-32} | {Saleproduct.Price,-13} | {Saleproduct.WarrantiTime,-14}");
            }

            sales.Add(new Sale(newTime, new Employee(newEmployee), new Client(newClient), new List<Product>(productsToSell)));
        };

        static void CalculateSalesValue(List<Sale> sales)
        {
            if (sales.Count == 0)
            {
                Console.WriteLine("There are no sales in the list.");
                return;
            }

            string productLineSeparator = new('-', 90);
            Console.WriteLine($"{"Nro",-4} | {"Date",-12} | {"Seller",-14} | {"Buyer",-14} | {"Products",-5}");
            Console.WriteLine(productLineSeparator);

            for (var i = 0; i < sales.Count; i++)
            {
                var sale = sales[i];
                Console.WriteLine($"{i + 1,-4} | {sale.Date.ToShortDateString(),-12} | {sale.Seller.Name,-14} | {sale.Buyer.Name,-14}");

                foreach (var product in sale.Products)
                {
                    Console.WriteLine($"{new string(' ', 34)} - {product.Name,-45} {product.Price,10:C}");
                }

                Console.WriteLine(productLineSeparator);
            }

            int saleIndex = InputInt("Seleccione el número de la venta para ver los detalles y el total: ");
            saleIndex--;

            if (saleIndex < 0 || saleIndex >= sales.Count)
            {
                Console.WriteLine("Índice no válido.");
                return;
            }

            var selectedSale = sales[saleIndex];
            decimal totalAmount = selectedSale.Products.Sum(product => product.Price);

            Console.Clear();
            Console.WriteLine("Detalles de la venta seleccionada:");
            Console.WriteLine($"Fecha: {selectedSale.Date.ToShortDateString()}");
            Console.WriteLine($"Vendedor: {selectedSale.Seller.Name}");
            Console.WriteLine($"Comprador: {selectedSale.Buyer.Name}");
            Console.WriteLine("Productos:");

            foreach (var product in selectedSale.Products)
            {
                Console.WriteLine($"- {product.Name}: {product.Price:C}");
            }

            Console.WriteLine($"Valor total de la venta: {totalAmount:C}");
        }

        static void CalculateAverageDailySales(List<Sale> sales)
        {
            DateTime dateSearch = InputDate("Enter specific date of the sale (MM/DD/YYYY) => ");
            var foundSales = sales.Where(sale => sale.Date.Date == dateSearch.Date).ToList();

            if (foundSales.Count > 0)
            {
                decimal totalSalesAmount = 0;
                int totalProductsCount = 0;

                foreach (var sale in foundSales)
                {
                    foreach (var product in sale.Products)
                    {
                        totalSalesAmount += product.Price;
                        totalProductsCount++;
                    }
                }

                decimal averageSalesAmount = Math.Round(totalSalesAmount / totalProductsCount, 2);

                foreach (var sale in foundSales)
                {
                    Console.WriteLine($"{averageSalesAmount,-20} | {totalProductsCount,-5}");
                }
            }
            else
            {
                Console.WriteLine("No sales related to the date entered.");
            }
        }

        static void NumberSales(List<Sale> sales)
        {
            DateTime dateSearch = InputDate("Enter specific date of the sale (MM/DD/YYYY) => ");
            var foundSales = sales.Where(sale => sale.Date >= dateSearch).ToList();

            if (foundSales.Count.Equals(0))
            {
                Console.WriteLine("No sales related to the date entered.");
            }
            else
            {
                foreach (var datesFound in foundSales)
                {
                    Console.WriteLine($"{datesFound.Date,-10} | {datesFound.Seller.Name,-20} | {datesFound.Buyer.Name,-20} | {datesFound.Products.Count,-5}");
                }
            }
        };

        static void GroupTotalSales(List<Sale> sales)
        {
            var groupedSales = sales.GroupBy(sale => sale.Date.Month);

            foreach (var group in groupedSales)
            {
                var month = group.Key;
                var totalSales = group.Sum(sale => sale.Products.Sum(product => product.Price));

                Console.WriteLine($"Mes: {month} - Total de Ventas: {totalSales:C}");
            }
        };

        static void SortSaleDesending(List<Sale> sales)
        {
            var sortedSales = sales.OrderByDescending(sale => sale.Date).ToList();

            Console.Write("¿Cuántas ventas deseas ver? ");
            int quantity;
            while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0 || quantity > sortedSales.Count)
            {
                Console.WriteLine("Por favor, ingresa un número válido mayor a 0 y menor o igual a la cantidad de ventas disponibles.");
                Console.Write("¿Cuántas ventas deseas ver? ");
            }

            Console.WriteLine($"Mostrando las primeras {quantity} ventas ordenadas en orden descendente:");

            string productLineSeparator = new('-', 90);
            Console.WriteLine($"{"Nro",-4} | {"Date",-12} | {"Seller",-14} | {"Buyer",-14} | {"Products",-5}");
            Console.WriteLine(productLineSeparator);

            for (var i = 0; i < quantity; i++)
            {
                var sale = sortedSales[i];
                Console.WriteLine($"{i + 1,-4} | {sale.Date.ToShortDateString(),-12} | {sale.Seller.Name,-14} | {sale.Buyer.Name,-14}");

                foreach (var product in sale.Products)
                {
                    Console.WriteLine($"{new string(' ', 34)} - {product.Name,-25} {product.Price,10:C}");
                }

                Console.WriteLine(productLineSeparator);
            }
        };

        static void SearchSale(List<Sale> sales)
        {
            Console.Write("Ingrese el valor total de la venta que desea buscar: ");
            decimal targetTotal;
            while (!decimal.TryParse(Console.ReadLine(), out targetTotal) || targetTotal < 0)
            {
                Console.WriteLine("Por favor, ingrese un valor válido.");
                Console.Write("Ingrese el valor total de la venta que desea buscar: ");
            }

            var matchingSales = sales.Where(sale => sale.Products.Sum(product => product.Price) == targetTotal).ToList();

            if (matchingSales.Count == 0)
            {
                Console.WriteLine("No se encontraron ventas con el valor total especificado.");
                return;
            }

            Console.WriteLine($"Se encontraron {matchingSales.Count} ventas con el valor total de {targetTotal:C}:");

            string productLineSeparator = new('-', 90);
            Console.WriteLine($"{"Nro",-4} | {"Date",-12} | {"Seller",-14} | {"Buyer",-14} | {"Products",-5}");
            Console.WriteLine(productLineSeparator);

            for (var i = 0; i < matchingSales.Count; i++)
            {
                var sale = matchingSales[i];
                Console.WriteLine($"{i + 1,-4} | {sale.Date.ToShortDateString(),-12} | {sale.Seller.Name,-14} | {sale.Buyer.Name,-14}");

                foreach (var product in sale.Products)
                {
                    Console.WriteLine($"{new string(' ', 34)} - {product.Name,-25} {product.Price,10:C}");
                }

                Console.WriteLine(productLineSeparator);
            }
        };

        static void FindHighestSale(List<Sale> sales)
        {
            var groupedSales = sales.GroupBy(sale => sale.Date.Month)
                                            .OrderByDescending(group => group.Count())
                                            .FirstOrDefault();

            if (groupedSales == null)
            {
                Console.WriteLine("No hay ventas disponibles.");
                return;
            }

            var month = groupedSales.Key;
            var monthName = new DateTime(1, month, 1).ToString("MMMM");

            Console.WriteLine($"El mes con el mayor número de ventas es {monthName} con {groupedSales.Count()} ventas:");

            string productLineSeparator = new('-', 90);
            Console.WriteLine($"{"Nro",-4} | {"Date",-12} | {"Seller",-14} | {"Buyer",-14} | {"Products",-5}");
            Console.WriteLine(productLineSeparator);

            int saleNumber = 1;
            foreach (var sale in groupedSales)
            {
                Console.WriteLine($"{saleNumber,-4} | {sale.Date.ToShortDateString(),-12} | {sale.Seller.Name,-14} | {sale.Buyer.Name,-14}");

                foreach (var product in sale.Products)
                {
                    Console.WriteLine($"{new string(' ', 34)} - {product.Name,-25} {product.Price,10:C}");
                }

                Console.WriteLine(productLineSeparator);
                saleNumber++;
            }
        };

        static void BestSellingProducts(List<Sale> sales)
        {
            var productSales = new Dictionary<string, List<DateTime>>();

            foreach (var sale in sales)
            {
                foreach (var product in sale.Products)
                {
                    if (!productSales.ContainsKey(product.Name))
                    {
                        productSales[product.Name] = new List<DateTime>();
                    }
                    productSales[product.Name].Add(sale.Date);
                }
            }

            var bestSellingProduct = productSales.OrderByDescending(p => p.Value.Count).FirstOrDefault();

            if (bestSellingProduct.Key == null)
            {
                Console.WriteLine("No se encontraron ventas.");
                return;
            }

            var productName = bestSellingProduct.Key;
            var salesDates = bestSellingProduct.Value;

            var bestSellingMonth = salesDates.GroupBy(date => date.Month).OrderByDescending(group => group.Count()).FirstOrDefault();

            var monthWithMostSales = new DateTime(1, bestSellingMonth.Key, 1).ToString("MMMM");

            Console.WriteLine($"El producto más vendido es {productName} con {salesDates.Count} ventas.");
            Console.WriteLine($"El mes con más ventas para {productName} es {monthWithMostSales} con {bestSellingMonth.Count()} ventas.");
        };

        static void ShowProducts(List<Product> products)
        {
            if (products.Count.Equals(0))
            {
                Console.WriteLine("There are no products in the list.");
                return;
            }

            string productLineSeparator = new('-', maxWidth);
            Console.WriteLine($"Nro | {"Name",-32} | {"warranties",-14} | {"Price",-13}");
            Console.WriteLine(productLineSeparator);

            for (var i = 0; i < products.Count; i++)
            {
                var product = products[i];
                Console.WriteLine($"{i + 1,-3} | {product.Name,-32} | {$"{product.WarrantiTime} Meses",-14}  | {product.Price,-13}");
            }
        };

        static void EmployeeMonth(List<Sale> sales)
        {
            var employeeSales = sales.GroupBy(sale => sale.Seller.Name).Select(group => new { EmployeeName = group.Key, SalesCount = group.Count() }).OrderByDescending(result => result.SalesCount).ToList();

            Console.WriteLine("Empleados con mayor número de ventas:");
            foreach (var employee in employeeSales)
            {
                Console.WriteLine($"Empleado: {employee.EmployeeName}, Ventas: {employee.SalesCount}");
            }
        };

        static void SellerSalesAboveValue(List<Sale> sales)
        {
            decimal minValue = InputDecimal("Ingrese el valor mínimo de ventas => ");

            var sellerSales = sales.GroupBy(sale => sale.Seller.Name).Select(group => new{ SellerName = group.Key, TotalSales = group.Sum(sale => sale.Products.Sum(product => product.Price))}).Where(seller => seller.TotalSales > minValue).OrderByDescending(seller => seller.TotalSales).ToList();

            if (sellerSales.Count == 0)
            {
                Console.WriteLine("No hay vendedores con ventas mayores al valor ingresado.");
                return;
            }

            Console.WriteLine($"Vendedores con ventas mayores a {minValue:C2}:");
            foreach (var seller in sellerSales)
            {
                Console.WriteLine($"Vendedor: {seller.SellerName}, Total de Ventas: {seller.TotalSales:C2}");
            }
        };

        static void SellerHighestNumberSales(List<Sale> sales)
        {
            DateTime startDate = InputDate("Ingrese la fecha de inicio (MM/DD/YYYY) => ");
            DateTime endDate = InputDate("Ingrese la fecha de fin (MM/DD/YYYY) => ");

            var salesInRange = sales.Where(sale => sale.Date >= startDate && sale.Date <= endDate).ToList();

            if (salesInRange.Count == 0)
            {
                Console.WriteLine("No hay ventas en el periodo especificado.");
                return;
            }

            var topSeller = salesInRange.GroupBy(sale => sale.Seller.Name)
                                        .Select(group => new
                                        {
                                            SellerName = group.Key,
                                            SalesCount = group.Count()
                                        })
                                        .OrderByDescending(result => result.SalesCount)
                                        .FirstOrDefault();

            if (topSeller != null)
            {
                Console.WriteLine($"El vendedor con el mayor número de ventas en el periodo especificado es: {topSeller.SellerName}, con {topSeller.SalesCount} ventas.");
            }
            else
            {
                Console.WriteLine("No se encontraron vendedores en el periodo especificado.");
            }
        };

        static void TotalSellerSales(List<Sale> sales)
        {
            var employeeSales = sales.GroupBy(sale => sale.Seller.Name).Select(group => new { EmployeeName = group.Key, TotalSales = group.Sum(sale => sale.Products.Sum(product => product.Price)), AverageSales = group.Average(sale => sale.Products.Sum(product => product.Price)) }).OrderByDescending(result => result.TotalSales).ToList();

            Console.WriteLine("Total de ventas y promedio de ventas por empleado:");
            foreach (var employee in employeeSales)
            {
                Console.WriteLine($"Empleado: {employee.EmployeeName}, Total de Ventas: {employee.TotalSales:C2}, Promedio de Ventas: {employee.AverageSales:C2}");
            }
        };

        static void FinishOption()
        {
            string message = "Presione cualquier tecla para volver al menú principal...";
            Console.WriteLine(message);
            Console.ReadKey();
            Console.Clear();
        }

        static void MostarMenu()
        {
            Console.WriteLine(@"
            1. Clients.
            2. Sales.
            3. Products.
            4. Employees.
            5. Exit.
            ");
        }

        bool MenuOpen = true;
        while (MenuOpen)
        {
            string MenuMessage = Header("Gestor de Ventas");
            Console.WriteLine(MenuMessage);
            MostarMenu();
            int option = InputInt("Enter option => ");
            Console.Clear();

            switch (option)
            {
                case 1:
                    Console.WriteLine($"{Header("CLIENTS")}");
                    Console.WriteLine(@"
                    1. Client of the month.
                    2. The bests clients.
                    3. Sales made to clients
                    ");
                    int optionOne = InputInt("Enter option => ");
                    switch (optionOne)
                    {
                        case 1:
                            ClientMonth(sales);
                            FinishOption();
                            break;
                        case 2:
                            BestClients(sales);
                            FinishOption();
                            break;
                        case 3:
                            ClientSales(sales);
                            FinishOption();
                            break;
                        default:
                            Console.WriteLine("Opción no válida"); break;
                    }
                    break;
                case 2:
                    Console.WriteLine($"{Header("SALES")}");
                    Console.WriteLine(@"
                    1. Record sales.
                    2. Calculate sales value.
                    3. Calculate average daily sales.
                    4. Number of sales (Specific date).
                    5. Group sales by month and total sales.
                    6. Sort sales in descending order and show selected quantity.
                    7. search for sale by value
                    8. Find month with the highest number of sales.
                    ");
                    int optionTwo = InputInt("Enter option => ");
                    switch (optionTwo)
                    {
                        case 1:
                            RecordSales(products, sales);
                            FinishOption();
                            break;
                        case 2:
                            CalculateSalesValue(sales);
                            FinishOption();
                            break;
                        case 3:
                            CalculateAverageDailySales(sales);
                            FinishOption();
                            break;
                        case 4:
                            NumberSales(sales);
                            FinishOption();
                            break;
                        case 5:
                            GroupTotalSales(sales);
                            FinishOption();
                            break;
                        case 6:
                            SortSaleDesending(sales);
                            FinishOption();
                            break;
                        case 7:
                            SearchSale(sales);
                            FinishOption();
                            break;
                        case 8:
                            FindHighestSale(sales);
                            FinishOption();
                            break;
                        default:
                            Console.WriteLine("Invalid option!");
                            break;
                    }; break;
                case 3:
                    Console.WriteLine($"{Header("PRODUCTS")}");
                    Console.WriteLine(@"
                    1. Find best-selling products.
                    2. See all products.
                    ");
                    int optionThree = InputInt("Enter option => ");
                    switch (optionThree)
                    {
                        case 1:
                            BestSellingProducts(sales);
                            FinishOption();
                            break;
                        case 2:
                            ShowProducts(products);
                            FinishOption();
                            break;
                        default:
                            Console.WriteLine("Invalid option!");
                            break;
                    }; break;
                case 4:
                    Console.WriteLine($"{Header("EMPLOYEES")}");
                    Console.WriteLine(@"
                    1. Employee of the month.
                    2. Seller with sales above value.
                    3. Seller with the highest number of sales (Specific period).
                    4. Total seller sales and average sales per seller.
                    ");
                    int optionFour = InputInt("Enter option => ");
                    switch (optionFour)
                    {
                        case 1:
                            EmployeeMonth(sales);
                            FinishOption();
                            break;
                        case 2:
                            SellerSalesAboveValue(sales);
                            FinishOption();
                            break;
                        case 3:
                            SellerHighestNumberSales(sales);
                            FinishOption();
                            break;
                        case 4:
                            TotalSellerSales(sales);
                            FinishOption();
                            break;
                        default:
                            Console.WriteLine("Invalid option!");
                            break;
                    }; break;
                case 5:
                    MenuOpen = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}

public class Sale(DateTime date, Employee seller, Client buyer, List<Product> products)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public DateTime Date { get; set; } = date;
    public Employee Seller { get; set; } = seller;
    public Client Buyer { get; set; } = buyer;
    public List<Product> Products { get; set; } = products;
}


public class Product(string name, decimal price, int warrantiTime)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Name { get; set; } = name;
    public decimal Price { get; set; } = price;
    public int WarrantiTime { get; set; } = warrantiTime;
}

public class Client(string name)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Name { get; set; } = name;
}

public class Employee(string name)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Name { get; set; } = name;
}

// public class Mateo(string name, int age, DateTime birthday)
// {
//     public Guid Id { get; private set; } = Guid.NewGuid();
//     public string Name { get; set; } = name;

//     public int Age { get; set; } = age;
//     public DateTime Birthday { get; set; } = birthday;
// }


// {
//     DateTime dateSearch = InputDate("Enter specific date of the sale (MM/DD/YYYY) => ");
//     var foundSales = sales.Where(sale => sale.Date == dateSearch).ToList()
//     if (foundSales.Count() > 0)
//     {
//         foreach (var averageDailySale in foundSales)
//         {
//             decimal average
//             Console.WriteLine($"{averageDailySale.Date,-10} | {averageDailySale.Seller.Name,-20} | {averageDailySale,-20} | {averageDailySale.Products.Average(product => product.Price),-20} | {averageDailySale.Products.Count,-5}");
//         }
//     }else
//     {
//         Console.WriteLine("No sales related to the date entered.");
//     }
// };