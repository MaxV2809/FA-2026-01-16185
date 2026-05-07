using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE5
{
    internal class ejercicio3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int num = int.Parse(Console.ReadLine());

            int pares = 0;

            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine(i + "");
                if (i % 2 == 0)
                {
                    pares += i;
                    //pares = pares + i;
                }
            }
            Console.WriteLine("\nSuma de pares: "+pares);
        }
    }
}
