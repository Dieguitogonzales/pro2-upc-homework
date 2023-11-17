using System;

public class ArrayNum
{
    // Método para mostrar el máximo y el mínimo del array de enteros
    public static void MostrarMaxMinArrayEnteros(int[] array)
    {
        // Mostrar el array
        Console.WriteLine("Array de enteros:");
        MostrarArray(array);

        // Inicializar variables para almacenar el máximo y el mínimo
        int maximo = array[0];
        int minimo = array[0];

        // Iterar sobre el array para encontrar el máximo y el mínimo
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maximo)
            {
                maximo = array[i];
            }

            if (array[i] < minimo)
            {
                minimo = array[i];
            }
        }

        // Mostrar el máximo y el mínimo en la consola
        Console.WriteLine("Número máximo: " + maximo);
        Console.WriteLine("Número mínimo: " + minimo);
    }

    // Método para mostrar el array
    public static void MostrarArray(int[] array)
    {
        // Verificar si el array es nulo o está vacío
        if (array == null || array.Length == 0)
        {
            Console.WriteLine("El array está vacío o nulo.");
            return;
        }

        // Imprimir el array utilizando un bucle for
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    // Método para sumar los elementos del array
    public static void SumarElementosArray(int[] array)
    {
        int suma = 0;
        int n = array.Length;
        for (int i = 0; i < n; i++)
        {
            suma += array[i];
        }
        Console.WriteLine("La suma de los elementos del array es: " + suma);
    }

    // Método para retornar el promedio de los elementos del array
    public static double PromedioArrayEnteros(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine("No se puede calcular el promedio. El array está vacío o nulo.");
            return 0;
        }

        int suma = 0;
        int n = array.Length;

        // Calcular la suma de los elementos
        for (int i = 0; i < n; i++)
        {
            suma += array[i];
        }

        // Calcular el promedio
        double promedio = (double)suma / n;
        return promedio;
    }
     public static int FrecuenciaArrayEnteros(int[] array, int elemento)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine("No se puede calcular la frecuencia. El array está vacío o nulo.");
            return 0;
        }

        int frecuencia = 0;

        // Calcular la frecuencia del elemento en el array
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == elemento)
            {
                frecuencia++;
            }
        }

        return frecuencia;
    }
}
