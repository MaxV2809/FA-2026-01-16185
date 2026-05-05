using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE4
{
    internal class ejercicio3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Sistema de convesion de  moneda -----");
            Console.Write("Ingrese el monto en soles: ");
            double soles = double.Parse(Console.ReadLine());

            Console.WriteLine("**** Menu de opciones ****");
            Console.WriteLine("* 0. Dolares              *");
            Console.WriteLine("* 1. Euros                *");
            Console.WriteLine("**************************\n");

            Console.WriteLine("Ingrese una opcion: ");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 0:
                    double dolares;
                    dolares = soles / 3.75;

                    Console.WriteLine("\nDolares: " + Math.Round(dolares));
                    break;
                case 1:
                    double euro;
                    euro = soles / 4.05;

                    Console.WriteLine("\nEuros: " + Math.Round(euro, 1));
                    break;
                default: Console.WriteLine("\nOpcion incorrecta!:"); break;
            }
        }
    }
}
