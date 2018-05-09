using System;
using System.Collections.Generic;

using System.Linq;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Colecciones
            // Lista de elementos
            // que se trata como una unidad
            // Permite manipular su contenido

            // Matriz
            string[] listaNombres = {"Antonio", "Bea", "Mario", "Jose"};
            Console.WriteLine("Elementos en la lista: " + listaNombres.Length);

            for(int i=0; i < listaNombres.Length; i++)
            {
                Console.WriteLine(listaNombres[i]);
            }

            // Lista
            // List<tipo>
            List<Decimal> precios = new List<decimal>();
            precios.Add(23.23m);
            precios.Add(11.4523m);
            precios.Add(90.50m);

            var miPrecio = precios[2]; // 90.50

            var p1 = new Producto("1","Mahou", 15);
            var p2 = new Producto("1","Alhambra", 27);
            var p3 = new Producto("3","Amstel", 2.7);
            
            var productos = new List<Producto>();
            productos.Add(p1);
            productos.Add(p2);
            productos.Add(p3);
            productos.Add(new Producto("4","Cruzcampo",1.5));
            productos.Add(new Producto("5","Mahou negra", 2));

            productos.Remove(p2);
            Console.WriteLine("¿Donde está p3? posicion: " + productos.IndexOf(p3));
            
            // Lambda
            // función anónima
            var mahou = productos.Where(p => p.Nombre.ToUpper().Contains("MAH"));

            Console.WriteLine("¿Hay mahou? " + mahou.Any());
            ListarProductos(mahou.ToList());

            ListarProductos(productos);
            IncrementaPrecio(productos,5);
            ListarProductos(productos);

            // Diccionario
            var d = new Dictionary<string, Producto>();
            d.Add(p1.Codigo,p1);
            d.Add(p2.Codigo,p2);
            d.Add(p3.Codigo,p3);
        }

        private static void ListarProductos(List<Producto> productos)
        {
            Console.WriteLine("Productos disponibles...");
            foreach (var producto in productos)
            {
                Console.WriteLine(producto.Codigo + " - " + producto.Nombre + " precio: " + producto.Precio);
            }
        }

        private static void IncrementaPrecio(List<Producto> productos, double porcentaje)
        {
            var aplicar = 1 + (porcentaje/100);
            foreach (var producto in productos)
            {
                producto.Precio += producto.Precio * aplicar;
            }
        }

    }

    public class Producto
    {
        public string  Codigo { get; set; }
        public string Nombre { get; set; }

        public double Precio {get;set;}

        public Producto(string codigo, string nombre, double precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
        }
    }
}
