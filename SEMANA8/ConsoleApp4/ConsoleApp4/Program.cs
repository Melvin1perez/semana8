// See https://aka.ms/new-console-template for more information
using ConsoleApp4.Models;

Console.WriteLine("Hello, World!");

AlmacenContext db = new AlmacenContext();

Console.WriteLine("Ingrese el nombre del producto: ");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese la descripción del producto: ");
string descripcion = Console.ReadLine();
Console.WriteLine("Ingrese el precio del producto: ");
decimal precio = decimal.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el stock del producto: ");
int stock = int.Parse(Console.ReadLine());


var producto = new Producto1 { Nombre = nombre, Descripcion = descripcion, Precio = precio, Stock = stock };
db.Producto1s.Add(producto);
db.SaveChanges();

#region Listar
//var ListProducto1s = db.Producto1s.ToList();
//        foreach (var usu in ListProducto1s){
//            Console.WriteLine(usu.Nombre);
//        }
#endregion
#region Insertar
//Producto1 producto = new Producto1();
//producto.Nombre = "coca";
//producto.Descripcion = "gaseosa";
//producto.Precio = 34;
//producto.Stock = 2;

//db.Producto1s.Add(producto);
//db.SaveChanges();
#endregion