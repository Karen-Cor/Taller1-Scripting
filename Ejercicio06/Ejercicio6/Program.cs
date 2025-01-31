using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Ingrese la cantidad de números impares a sumar: ");
            int n = int.Parse(Console.ReadLine());

            int suma = 0, contador = 0, numero = 1;

            do
            {
                suma += numero; // Sumar el número impar actual
                numero += 2;    // Pasar al siguiente número impar
                contador++;      // Contar cuántos impares hemos sumado
            } while (contador < n);

            Console.WriteLine("La suma de los primeros " + n + " números impares es: " + suma);
        }
    }
}
