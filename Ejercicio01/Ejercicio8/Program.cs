using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Ingrese el número de filas: ");
            int filas = LeerEntero();

            Console.Write("Ingrese el número de columnas: ");
            int columnas = LeerEntero();

            int[,] matrizA = LeerMatriz(filas, columnas, "A");
            int[,] matrizB = LeerMatriz(filas, columnas, "B");

            Console.WriteLine("\nMatriz A:");
            ImprimirMatriz(matrizA);

            Console.WriteLine("\nMatriz B:");
            ImprimirMatriz(matrizB);

            int[,] matrizResultado = SumarMatrices(matrizA, matrizB);

            Console.WriteLine("\nMatriz Resultado (A + B):");
            ImprimirMatriz(matrizResultado);
        }

        static int LeerEntero()
        {
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Entrada inválida. Ingrese un número entero: ");
            }
            return numero;
        }

        static int[,] LeerMatriz(int filas, int columnas, string nombreMatriz)
        {
            int[,] matriz = new int[filas, columnas];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Ingrese el valor para la celda [{i},{j}] de la matriz {nombreMatriz}: ");
                    matriz[i, j] = LeerEntero(); // Lee el valor entero para cada celda
                }
            }
            return matriz;
        }

        static int[,] SumarMatrices(int[,] matrizA, int[,] matrizB)
        {
            int filas = matrizA.GetLength(0);
            int columnas = matrizA.GetLength(1);
            int[,] resultado = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    resultado[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }
            return resultado;
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
