using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            float d, f;



            Console.WriteLine("Ingerse un numero");
            a = int.Parse(Console.ReadLine());
            
            b = 10;
            c = a + b;

            Console.WriteLine("El resultado es: " + c);

            Console.ReadKey();
        }
    }
}
