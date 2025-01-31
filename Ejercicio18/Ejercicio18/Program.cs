using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduce un número de máximo 8 cifras:");

        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0 || numero > 99999999)
        {
            Console.WriteLine("Por favor, ingrese un número válido de máximo 8 cifras.");
        }

        int resultado = ReducirADigito(numero);
        Console.WriteLine($"El resultado de sumar los dígitos hasta obtener un solo dígito es: {resultado}");
    }

    static int ReducirADigito(int numero)
    {
        while (numero >= 10)  // Mientras el número tenga más de un dígito
        {
            int suma = 0;
            while (numero > 0)
            {
                suma += (int)(numero % 10);  // Suma el último dígito
                numero /= 10;  // Elimina el último dígito
            }
            numero = suma;  // Asigna la suma de los dígitos como el nuevo número
        }
        return (int)numero;  // Devuelve el número de un solo dígito
    }
}


