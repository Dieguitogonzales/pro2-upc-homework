using System;

namespace claseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio # 1 enteros maximo y minimo
            int[] arrayEnteros = { 5, 3, 8, 1, 9, 2, 7 };

            // Llamar al método para mostrar el máximo y el mínimo
            ArrayNum.MostrarMaxMinArrayEnteros(arrayEnteros);
            Console.WriteLine("------------------------");
            // ejercicio # 2 suma de array entero
            ArrayNum.SumarElementosArray(arrayEnteros);
            Console.WriteLine("------------------------");
            // ejercicio # 3 promedio de array enteros
            double promedio = ArrayNum.PromedioArrayEnteros(arrayEnteros);
            Console.WriteLine("El promedio del array de enteros es: " + promedio);
            Console.WriteLine("------------------------");

            // ejercicio # 5 mostrar la frecuencia de elementos de un array de enteros
            int elementoBuscadoEnteros = 3;
            int frecuenciaElementoEnteros = ArrayNum.FrecuenciaArrayEnteros(arrayEnteros, elementoBuscadoEnteros);
            Console.WriteLine($"La frecuencia de {elementoBuscadoEnteros} del  array de enteros es: {frecuenciaElementoEnteros}");
            Console.WriteLine("------------------------");

            // ejercicio # 4 de cadenas buscar un elemento array y mostrar true
            string[] arrayCadenas = { "Hola", "Mundo", "Programación", "C#", "Arrays" };

           
            Cadenas.MostrarArray(arrayCadenas);
           

            // Llamar al método y mostrar el resultado para el array de cadenas
            string elementoBuscadoCadenas = "C#";
            bool resultadoBusquedaCadenas = Cadenas.BuscarElementoEnArray(arrayCadenas, elementoBuscadoCadenas);
            Console.WriteLine(resultadoBusquedaCadenas ? "TRUE" : "FALSE");
            Console.WriteLine("------------------------");
          // ejercicio nro 7 de cadenas
          string[] arrayCadenasA = { "Hola", "Mundo", "Programación", "C#", "Arrays" };
            string[] arrayCadenasB = { "Hola", "C#", "Gatos", "Perros" };

            // Llamar al método para mostrar el complemento de A y B
            string[] complementoArrays = Cadenas.ComplementoArrays(arrayCadenasA, arrayCadenasB);
            Cadenas.MostrarArray(complementoArrays);
           Console.WriteLine("------------------------");
           // ejercicio # 8 de cadenas 
          int[] arrayEntero = Cadenas.ArrayCadenasToArrayEnteros(arrayCadenas);
            Console.Write("Array de enteros con equivalencia en ASCII: [");
            Console.WriteLine(string.Join(", ", arrayEnteros) + "]");
            Console.WriteLine("------------------------");
            //ejercicio # 9 - Dado dos array (A y B) de cadenas, retornar un nuevo array (C) con la diferencia A - B
            //public void DiferenciaArrayCadenasAyB()
            string[] diferenciaArrays = Cadenas.DiferenciaArrayCadenasAyB(arrayCadenasA, arrayCadenasB);
                        Cadenas.MostrarArray(diferenciaArrays);
                Console.WriteLine("------------------------");
            //ejercicio # 10 de cadenas - Dado un array de enteros retornar un array de cadenas con su equivalencia en ASCII
            //public void ArrayEnterosToArrayCadenas()

             // Ejemplo de uso con array de enteros
            int[] arraysEnteros = { 72, 101, 108, 108, 111 }; // Equivalente en ASCII de "Hello"

            // Llamar al método para mostrar el array de enteros
            ArrayNum.MostrarArray(arrayEnteros);

            // Llamar al método para obtener un array de cadenas con la equivalencia en ASCII
            string[] arraysCadenas = Cadenas.ArrayEnterosToArrayCadenas(arrayEnteros);

            // Llamar al método para mostrar el array de cadenas resultante
            Cadenas.MostrarArray(arrayCadenas);

                Console.WriteLine("------------------------");
             //ejercicio # 11 - Invertir todos los valores de un array de cadenas, de forma que el ultimo ahora sea el
            //primero, el penultimo el segundo y asi sucesivamente.
            //public void InvertirArrayCadenas()
            
            //"Hola", "Mundo", "Programación"
            
            Cadenas.MostrarArray(arrayCadenas);

            // Llamar al método para invertir el array de cadenas
            Cadenas.InvertirArrayCadenas(arrayCadenas);

            // Llamar al método para mostrar el array de cadenas invertido
            Cadenas.MostrarArray(arrayCadenas);

            Console.WriteLine("------------------------");
          //ejercicio #12 de cadenas
          // Ejemplo de uso con arrays de cadenas
            string[] arraysCadenasA = { "Hola", "Mundo", "Programación", "C#", "Arrays" };
            string[] arraysCadenasB = { "Hola", "C#", "Gatos", "Perros" };

            // Llamar al método para mostrar la diferencia B - A
            string[] diferenciaArray = Cadenas.DiferenciaArrayCadenasByA(arrayCadenasA, arrayCadenasB);
            Cadenas.MostrarArray(diferenciaArrays);
            


        }
    }
}


