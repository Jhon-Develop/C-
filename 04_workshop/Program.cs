// bool menu = true;
// List<Producto> productos = [];

// static void OpcionFinish(){

// }

// void AgregarProducto()
// {
//     Console.Write("Ingrese el nombre del producto => ");
//     string? nombre = Console.ReadLine();
//     Console.Write("Ingrese el precio unitario del producto => ");
//     double precioUnitario = double.Parse(Console.ReadLine());
//     Console.Write("Ingrese la cantidad disponible del producto =>");
//     int cantidadDisponible = int.Parse(Console.ReadLine());
//     Producto nuevoProducto = new(nombre, precioUnitario, cantidadDisponible);
//     productos.Add(nuevoProducto);

//     Console.WriteLine("");
//     Console.WriteLine("Prodducto agregado con exito");
//     Console.WriteLine("");


// };

// void ModificarProducto()
// {
//     Console.WriteLine("Ingrese el nombre del producto:");
//     string? nombre = Console.ReadLine();
//     Console.WriteLine("Ingrese el precio unitario del producto:");
//     double precioUnitario = double.Parse(Console.ReadLine());
//     Console.WriteLine("Ingrese la cantidad disponible del producto:");
//     int cantidadDisponible = int.Parse(Console.ReadLine());
//     Producto nuevoProducto = new(nombre, precioUnitario, cantidadDisponible);
//     productos.Add(nuevoProducto);
// };

// void EliminarProducto()
// {
//     Console.WriteLine("Ingrese el nombre del producto:");
//     string? nombre = Console.ReadLine();
//     Console.WriteLine("Ingrese el precio unitario del producto:");
//     double precioUnitario = double.Parse(Console.ReadLine());
//     Console.WriteLine("Ingrese la cantidad disponible del producto:");
//     int cantidadDisponible = int.Parse(Console.ReadLine());
//     Producto nuevoProducto = new(nombre, precioUnitario, cantidadDisponible);
//     productos.Add(nuevoProducto);
// };

// void ListarProductos()
// {
//     Console.WriteLine("Productos disponibles:");
//     foreach (Producto producto in productos)
//     {
//         Console.WriteLine(producto.Nombre + " - " + producto.PrecioUnitario + " - " + producto.CantidadDisponible);
//     }
// };

// void Menu()
// {
//     while (menu)
//     {
//         Console.Write(@"
// ###############################################################################################
// #                                        INVENTARIO                                           #
// ###############################################################################################
// 1. Agregar producto
// 2. Modificar producto
// 3. Eliminar producto
// 4. Listar productos
// 5. Salir
// -----------------------------------------------------------------------------------------------
// INGRESE OPCION: ");

//         int opcion = int.Parse(Console.ReadLine());

//         switch (opcion)
//         {
//             case 1:
//                 AgregarProducto();
//                 break;
//             case 2:
//                 ModificarProducto();
//                 break;
//             case 3:
//                 EliminarProducto();
//                 break;
//             case 4:
//                 ListarProductos();
//                 break;
//             case 5:
//                 menu = false;
//                 break;
//             default:
//                 Console.WriteLine("Opción no válida");
//                 break;
//         }
//     }
// };

// Menu();

// public class Producto
// {
//     public string Nombre { get; set; }
//     public double PrecioUnitario { get; set; }
//     public int CantidadDisponible { get; set; }

//     public Producto(string nombre, double precioUnitario, int cantidadDisponible)
//     {
//         Nombre = nombre;
//         PrecioUnitario = precioUnitario;
//         CantidadDisponible = cantidadDisponible;
//     }
// }

const int maxWidth = 95;

List<Dictionary<string, object>> products = [];

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
}


static double InputDouble(string prompt)
{
    Console.Write(prompt);

    double input;
    while (!double.TryParse((Console.ReadLine() ?? string.Empty).AsSpan(), out input))
    {
        Console.WriteLine("Por favor, ingresa un valor numérico");
        Console.Write(prompt);
    }
    return input;
}

static string InputString(string prompt)
{
    Console.Write(prompt);
    string input = Console.ReadLine() ?? string.Empty;
    return input;
}

static void FinishOption()
{
    string message = "Presione cualquier tecla para volver al menú principal...";
    Console.WriteLine(message);
    Console.ReadKey();
    Console.Clear();
}

static void AddProducts(List<Dictionary<string, object>> products)
{
    string addProductMessage = Header("AGREGAR PRODUCTOS");
    Console.WriteLine(addProductMessage);

    string productName = InputString("Nombre del producto => ");
    double productPrice = InputDouble("Precio unitario del producto => ");
    int productStock = InputInt("Cantidad disponible del producto => ");

    Dictionary<string, object> product = new();
    product.Add("Nombre", productName);
    product.Add("PrecioUnitario", productPrice);
    product.Add("Stock", productStock);

    products.Add(product);

    FinishOption();
}

static void ModifyProducts(List<Dictionary<string, object>> products)
{

}

static void DeleteProducts(List<Dictionary<string, object>> products)
{

}

static void ListProducts(List<Dictionary<string, object>> products)
{

}


static void Menu(ref List<Dictionary<string, object>> products)
{
    bool openMenu = true;
    while (openMenu)
    {
        string MenuMessage = Header("INVENTARIO");
        string menuItemsMessage =
    @$"1. Agregar producto
2. Modificar producto
3. Eliminar producto
4. Listar productos
5. Salir
{new string('-', maxWidth)}";
        Console.WriteLine(MenuMessage);
        Console.WriteLine(menuItemsMessage);
        int option = InputInt("INGRESE OPCIÓN => ");
        Console.Clear();

        switch (option)
        {
            case 1:
                AddProducts(products); break;
            case 2:
                ModifyProducts(products); break;
            case 3:
                DeleteProducts(products); break;
            case 4:
                ListProducts(products); break;
            case 5:
                openMenu = false;
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    };
}

Menu(ref products);