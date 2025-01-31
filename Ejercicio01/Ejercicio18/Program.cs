using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Ingrese un número de hasta 8 cifras: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int numero) && numero >= 0 && input.Length <= 8)
            {
                while (numero >= 10)
                {
                    int suma = 0;
                    while (numero > 0)
                    {
                        suma += numero % 10;
                        numero /= 10;
                    }
                    numero = suma;
                }
                Console.WriteLine("El número reducido a un solo dígito es: " + numero);
            }
            else
            {
                Console.WriteLine("Error, ingrese un número válido de hasta 8 cifras.");
            }
        }
    }
}
