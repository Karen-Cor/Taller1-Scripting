using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduce una cadena de números enteros positivos separados por espacios:");

            string input = Console.ReadLine();  // Lee la cadena de números
            string[] parts = input.Split(' ');  // Divide la cadena en partes por espacios
            int[] numbers = new int[parts.Length];  // Crea un array de enteros del tamaño adecuado

            bool valid = true;  // Variable para validar la entrada

            // Verifica que cada parte de la cadena sea un número entero positivo
            for (int i = 0; i < parts.Length; i++)
            {
                if (!int.TryParse(parts[i], out numbers[i]) || numbers[i] <= 0)
                {
                    valid = false;
                    Console.WriteLine($"'{parts[i]}' no es un número entero positivo.");
                    break;
                }
            }

            // Si la validación es correcta, muestra el array
            if (valid)
            {
                Console.WriteLine("Los números en el array son:");
                foreach (var number in numbers)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
