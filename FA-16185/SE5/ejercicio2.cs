using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE5
{
    internal class ejercicio2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese lado 1: ");
            int lado1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado 2: ");
            int lado2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado 3: ");
            int lado3 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (lado1 == lado2 && lado2 == lado3)
                Console.WriteLine("Equilatero");
            else if(lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
                Console.WriteLine("Isoceles");              
            else 
                Console.WriteLine("Escaleno");           
        }
    }
}
