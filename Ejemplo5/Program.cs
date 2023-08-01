using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //funciones
            string nombre;
            Console.WriteLine("Cual es tu nombre?");
            nombre = Console.ReadLine();
            Console.WriteLine(saludar(nombre));
            Console.ReadKey();

        }

        static int sumar(int a , int b)
        {
            return a + b;
        }

        static string saludar (string nombre)
        {
            return "Hola " + nombre;
        }
    }
}
