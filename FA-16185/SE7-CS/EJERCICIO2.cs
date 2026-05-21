using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE7_CS
{
    internal class EJERCICIO2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("| BIENVENIDO AL JUEGO ADIVINADOR---");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Instrucciones : ");
            Console.WriteLine("1. Usted debe de adivinar el numero que esta en el rango de 1 - 20.");
            Console.WriteLine("2. Usted tiene 3 intentos");
            Console.WriteLine("3. Usted vera un mensaje de apoyo por cada intento fallido\n");

            int intentos = 3;
            int num;
            Random rand = new Random();
            int aleatorio = rand.Next(1, 21);
            do
            {
                Console.Write("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());
                if (num == aleatorio)
                {
                    Console.WriteLine("Felicidades Ud, adivino el numero");
                    break;
                }else if(num > aleatorio)
                {
                    Console.WriteLine("el numero a adivinar es menor"+intentos+"intenos\n");
                    aleatorio--;
                }
                else
                {
                    Console.WriteLine("El numero a adivinar es mayor. Te quedan"+intentos+"intentos\n");
                }
            } while (intentos>=0);
            if (intentos == 0)
            {
                Console.WriteLine("El numero aleatorio era: "+aleatorio);
            }

        }
    }
}
