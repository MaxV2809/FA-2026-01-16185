using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1_C
{
    internal class ejercicio3
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese numero 1: ");
            int num1 = int.Parse(Console.ReadLine()); 
            Console.Write("Ingrese numero 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nsuma : "+(num1+num2));
            Console.WriteLine("resta :" + (num1 - num2));
            Console.WriteLine("multiplicacion : " + (num1 * num2));
            Console.WriteLine("division : " + (num1 / num2));

            Console.ReadKey();
        }
    }
}
