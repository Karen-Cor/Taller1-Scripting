using System;
class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de números impares a sumar: ");
        int n = int.Parse(Console.ReadLine());

        int suma = 0, contador = 0, numero = 1;

        do
        {
            suma += numero; 
            numero += 2;   
            contador++;     
        } while (contador < n);

        Console.WriteLine("La suma de los primeros " + n + " números impares es: " + suma);
    }
}
