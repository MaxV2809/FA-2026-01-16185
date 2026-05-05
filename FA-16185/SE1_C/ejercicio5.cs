using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1_C
{
    internal class ejercicio5
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            string num = Console.ReadLine();

            int entero = int.Parse(num);
            double deci = double.Parse(num);

            Console.WriteLine($"\nEntero %2: {entero%2}");
            Console.WriteLine($"Decimal /3: {deci/3}");

        }
    }
}
