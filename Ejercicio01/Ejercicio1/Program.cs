using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el número de filas: ");
        int filas = LeerEntero();

        Console.Write("Ingrese el número de columnas: ");
        int columnas = LeerEntero();

        int[,] matriz = LeerMatriz(filas, columnas);

        Console.WriteLine("\nMatriz ingresada:");
        ImprimirMatriz(matriz);

        // Reemplazar los valores negativos
        ReemplazarNegativos(matriz);

        Console.WriteLine("\nMatriz modificada:");
        ImprimirMatriz(matriz);
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

    static int[,] LeerMatriz(int filas, int columnas)
    {
        int[,] matriz = new int[filas, columnas];
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"Ingrese el valor para la celda [{i},{j}]: ");
                matriz[i, j] = LeerEntero(); // Lee el valor entero para cada celda
            }
        }
        return matriz;
    }

    static void ReemplazarNegativos(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                if (matriz[i, j] < 0)
                {
                    matriz[i, j] = Math.Abs(matriz[i, j]); // Reemplaza los negativos por su valor absoluto
                }
            }
        }
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
