using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduce una cadena:");
            string cadena = Console.ReadLine();

            if (EsPalindromo(cadena))
            {
                Console.WriteLine("La cadena es un palíndromo.");
            }
            else
            {
                Console.WriteLine("La cadena no es un palíndromo.");
            }
        }

        static bool EsPalindromo(string cadena)
        {
            // Eliminar espacios y convertir todo a minúsculas para hacer la comparación insensible a mayúsculas/minúsculas
            cadena = cadena.Replace(" ", "").ToLower();

            // Comprobar si la cadena es igual a su reverso
            int longitud = cadena.Length;

            for (int i = 0; i < longitud / 2; i++)
            {
                if (cadena[i] != cadena[longitud - i - 1])
                {
                    return false;  // No es un palíndromo si los caracteres no coinciden
                }
            }

            return true;  // Es un palíndromo si todas las comparaciones son iguales
        }
    }
}
