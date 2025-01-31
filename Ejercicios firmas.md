```
    // 1. Función sin parámetros y sin retorno
    static void Saludar()
    {
        Console.WriteLine("¡Hola, mundo!");
    }

    // 2. Función con parámetros y sin retorno
    static void Sumar(int a, int b)
    {
        Console.WriteLine($"La suma es: {a + b}");
    }

    // 3. Función con parámetros y con retorno
    static int Multiplicar(int a, int b)
    {
        return a * b;
    }

    // 4. Función con parámetros de tipo cadena y retorno de cadena
    static string Concatenar(string str1, string str2)
    {
        return str1 + " " + str2;
    }

    // 5. Función con parámetros de tipo matriz y sin retorno
    static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // 6. Función con parámetros de tipo matriz y retorno de tipo escalar
    static int SumarMatriz(int[,] matriz)
    {
        int suma = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                suma += matriz[i, j];
            }
        }
        return suma;
    }

    // 7. Función con parámetros de tipo clase y sin retorno
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    static void MostrarPersona(Persona persona)
    {
        Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}");
    }

    // 8. Función con parámetros de tipo clase y retorno de tipo cadena
    static string ObtenerInfoPersona(Persona persona)
    {
        return $"Nombre: {persona.Nombre}, Edad: {persona.Edad}";
    }

    // 9. Función con parámetros opcionales
    static void MostrarMensaje(string mensaje = "Mensaje predeterminado")
    {
        Console.WriteLine(mensaje);
    }

    // 10. Función con parámetros de tipo lista y retorno de tipo lista
    static List<int> FiltrarPares(List<int> numeros)
    {
        return numeros.Where(n => n % 2 == 0).ToList();
    }

    // 11. Función con parámetros de tipo diccionario y sin retorno
    static void MostrarDiccionario(Dictionary<string, int> diccionario)
    {
        foreach (var item in diccionario)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }

    // 12. Función con parámetros de tipo enumeración y retorno de tipo cadena
    enum DiaSemana { Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo }
    static string ObtenerDia(DiaSemana dia)
    {
        return dia.ToString();
    }

    // 13. Función con parámetros de tipo tupla y retorno de tipo tupla
    static (int, int) SumarTupla((int, int) tupla)
    {
        return (tupla.Item1 + tupla.Item2, tupla.Item1 * tupla.Item2);
    }

    // 14. Función con parámetros de tipo delegado y sin retorno
    delegate void MiDelegado(string mensaje);
    static void EjecutarDelegado(MiDelegado delegado, string mensaje)
    {
        delegado(mensaje);
    }

    // 15. Función con parámetros de tipo acción y sin retorno
    static void EjecutarAccion(Action<string> accion, string mensaje)
    {
        accion(mensaje);
    }

    // 16. Función con parámetros de tipo función y retorno de tipo escalar
    static int EjecutarFuncion(Func<int, int, int> funcion, int a, int b)
    {
        return funcion(a, b);
    }

    // 17. Función con parámetros de tipo objeto y retorno de tipo objeto
    static object ObtenerObjeto(object obj)
    {
        return obj;
    }

    // 18. Función con parámetros de tipo genérico y retorno de tipo genérico
    static T MostrarValor<T>(T valor)
    {
        Console.WriteLine(valor);
        return valor;
    }

    // 19. Función con parámetros de tipo matriz de cadenas y retorno de tipo cadena
    static string ConcatenarMatriz(string[] matriz)
    {
        return string.Join(" ", matriz);
    }

    // 20. Función con parámetros de tipo matriz de objetos y retorno de tipo lista
    static List<object> ConvertirMatrizALista(object[] matriz)
    {
        return matriz.ToList();
    }

```
