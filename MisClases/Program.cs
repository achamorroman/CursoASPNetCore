using System;
using MisClases.Gente;

namespace MisClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Producto p = new Producto("0001", "Platanito");
            var p2 = new Producto("0002", "Mora negra", 0.05m);
            var p3 = new Producto("0003", "Dentadura", 1);
            var p4 = new Producto("0004", "fresa");

            Console.WriteLine(p.GetDescripcionProducto());
            Console.WriteLine(p2.GetDescripcionProducto());
            Console.WriteLine(p3.GetDescripcionProducto());
            Console.WriteLine(p4.GetDescripcionProducto());

            var yo = new Plebeyo("Antonio", "Chamorro",42, Genero.Hombre, "profe");
            var otro = new Plebeyo("Juan", "Gomez", 35,Genero.Hombre,"Carpintero");
            var otromas = new Plebeyo("Maria","Suarez", 32,Genero.Mujer, "Bailarina");

            var duque = new Aristocrata("Manuel", "Delgado", 55, Genero.Hombre, "Duque");
            var conde = new Aristocrata("Javier", "De las Heras", 65, Genero.Hombre, "Conde");
            var marques = new Aristocrata("Leonor", "Vinuesa", 25, Genero.Mujer, "Marquesa");

            PrintDatos(yo);
            PrintDatos(duque);
            PrintDatos(otro);
            PrintDatos(marques);
           
        }

        static void PrintDatos(Persona p)
        {
            Console.WriteLine(p.GetDatos());
        }
    }
}
