## Punto#6

Inicialice y declare 5 variables de diferente tipo.

```
using System;

class Program
{
    static void Main()
    {
        // 1. Entero (int)
        int edad = 25;

        // 2. Número decimal (double)
        double precio = 19.99;

        // 3. Cadena de texto (string)
        string nombre = "Carlos";

        // 4. Booleano (bool)
        bool esEstudiante = true;

        // 5. Carácter (char)
        char inicial = 'C';

        // Mostrar los valores
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Precio: {precio}");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"¿Es estudiante?: {esEstudiante}");
        Console.WriteLine($"Inicial: {inicial}");
    }
}
```


## Punto#8

Realice un ciclo infinito usando un ciclo for.

```
using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i >= 1; i++) // La condición siempre es verdadera
        {
            Console.WriteLine($"Iteración número: {i}");
        }
    }
}

```
