using System;

namespace claseArray
{
    public class Cadenas
    {
        // Método para buscar un elemento en un array de cadenas
        public static bool BuscarElementoEnArray(string[] array, string elemento)
        {
        
            return Array.Exists(array, e => e == elemento);
        }

        // Método para mostrar un array de cadenas 
        
        public static void MostrarArray(string[] array)
        {
            Console.Write("Array de cadenas: [");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine("]");
        }
        // Método para retornar un nuevo array con el complemento de A y B nro #7
         public static string[] ComplementoArrays(string[] arrayA, string[] arrayB)
        {
            
            return arrayA.Except(arrayB).ToArray();
        }
        //ejercicio#8 de cadenas  retornar un array de enteros con su equivalencia en ASCII
        //public void ArrayCadenasToArrayEnteros()
 public static int[] ArrayCadenasToArrayEnteros(string[] arrayCadenas)
        {
            int[] arrayEntero = new int[arrayCadenas.Length];

            for (int i = 0; i < arrayCadenas.Length; i++)
            {
                // Obtener la equivalencia en ASCII 
                int sumaAscii = arrayCadenas[i].Sum(c => (int)c);
                arrayEntero[i] = sumaAscii;
            }

            return arrayEntero;
         }
                //ejercicio # 9 - Dado dos array (A y B) de cadenas, retornar un nuevo array (C) con la diferencia A - B
                //public void DiferenciaArrayCadenasAyB()
                //string[] arrayCadenasA = { "Hola", "Mundo", "Programación", "C#", "Arrays" };
                //string[] arrayCadenasB = { "Hola", "C#", "Gatos", "Perros" };
                public static string[] DiferenciaArrayCadenasAyB(string[] arrayA, string[] arrayB)
        {
            return arrayA.Except(arrayB).ToArray();
        }
            // ejercicio #10 de cadenas - Dado un array de enteros retornar un array de cadenas con su equivalencia en ASCII
            //public void ArrayEnterosToArrayCadenas()

            public static string[] ArrayEnterosToArrayCadenas(int[] arrayEnteros)
        {
            string[] arrayCadenas = new string[arrayEnteros.Length];

            for (int i = 0; i < arrayEnteros.Length; i++)
            {
                // Convertir la equivalencia en ASCII a cadena y asignarla al array de cadenas
                arrayCadenas[i] = ((char)arrayEnteros[i]).ToString();
            }

            return arrayCadenas;
        }
            //ejercicio # 11 - Invertir todos los valores de un array de cadenas, de forma que el ultimo ahora sea el
            //primero, el penultimo el segundo y asi sucesivamente.
            //public void InvertirArrayCadenas()
            public static void InvertirArrayCadenas(string[] arrayCadenas)
        {
            int longitud = arrayCadenas.Length;
            for (int i = 0; i < longitud / 2; i++)
            {
                // Intercambiar los valores desde el principio hasta la mitad con los valores desde el final hasta la mitad
                string temp = arrayCadenas[i];
                arrayCadenas[i] = arrayCadenas[longitud - 1 - i];
                arrayCadenas[longitud - 1 - i] = temp;
            }
        }
        //ejercicio # 12 cadenas
            public static string[] DiferenciaArrayCadenasByA(string[] arrayA, string[] arrayB)
        {
            return arrayB.Except(arrayA).ToArray();
        }
        }
       
}