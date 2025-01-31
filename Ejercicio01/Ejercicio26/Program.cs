using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("¿Cuántos números flotantes desea ingresar?");
            int n;

            // Leer la cantidad de números a ingresar
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Por favor, ingrese un número entero positivo para la cantidad de valores.");
            }

            float suma = 0;  // Variable para acumular la suma de los números
            int contador = 0;  // Contador para el ciclo

            // Ciclo while para ingresar los números flotantes
            while (contador < n)
            {
                Console.WriteLine($"Ingrese el número flotante {contador + 1}:");

                float numero;
                while (!float.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Por favor, ingrese un número flotante válido.");
                }

                suma += numero;  // Acumula el número en la suma
                contador++;  // Incrementa el contador
            }

            // Calcular el promedio
            float promedio = suma / n;

            // Mostrar el resultado
            Console.WriteLine($"El promedio de los {n} números ingresados es: {promedio}");
        }
    }
}
