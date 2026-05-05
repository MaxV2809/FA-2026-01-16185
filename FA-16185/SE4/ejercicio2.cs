using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE4
{
    internal class ejercicio2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Año: ");
            int an = int.Parse(Console.ReadLine());
            if ((an % 4 == 0 && an % 100 != 0) || an % 400 == 0)
                Console.WriteLine("\nBisiesto");
            else Console.WriteLine("\nNo bisiesto");

            if (an % 2 == 0) Console.WriteLine("Par");
            else Console.WriteLine("impar");
        }
    }
}
