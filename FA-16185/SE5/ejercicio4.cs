using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE5
{
    internal class ejercicio4
    {
        static void Main(string[] args)
        {
            int num;
            int Cpares = 0, Cimpares = 0, Cceros = 0;

            Console.Write("Ingrese la cantidad de numeros: ");
            int cant = int.Parse(Console.ReadLine());

            for (int i = 0; i < cant; i++)
            {
                Console.Write($"Ingrese el numero{i + 1}:  ");
            }
            num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Cceros++;
            }
            else if (num % 2 != 0)
            {
                Cimpares++;
            }
            else
            {
                Cpares++;
            }
            Console.WriteLine("\n\nPares: " + Cpares);
            Console.WriteLine("Impares: "+ Cimpares);
            Console.WriteLine("Ceros: " + Cceros);
        }
    }
}


