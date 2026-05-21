using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE7_CS
{
    internal class EJERCICIO3
    {
        static void Main(string[] args)
        {
            string continuar;
            int num;
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                if (num <= 0) Console.WriteLine("El numero debe ser mayor a 0!!!!\n");
                else
                {
                    int suma = 0;
                    int i = 1;
                    do
                    {
                        suma += i;
                        i++;
                    } while (i <= num);
                    Console.WriteLine($"\nLa suma de los numeros de 1 hasta {num} es {suma}:");
                }
                Console.WriteLine("Desea continuar? (precione si): ");
                continuar = Console.ReadLine();
            } while (continuar=="si");
        }
    }
}
