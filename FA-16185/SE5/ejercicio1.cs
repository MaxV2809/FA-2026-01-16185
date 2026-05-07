using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SE5
{
    internal class ejercicio1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Puede Votar");
                if (edad >= 25)
                {
                    Console.WriteLine("Puede ser politico");
                }
            }
           
            else Console.WriteLine("No puede votar ni ser politico");
        }
    }
}
