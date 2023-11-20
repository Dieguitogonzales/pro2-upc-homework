using System;

namespace CodigoFacilitoVideo2
{
    static class Comparador
    {
        public static void CompararValores(int valor1, int valor2)
        {
            if (valor1 == valor2)
                Console.WriteLine("El valor 2 es igual al valor 1");
            else if (valor1 > valor2)
                Console.WriteLine("El valor 1 es mayor que el valor 2");
            else
                Console.WriteLine("El valor 2 es mayor que el valor 1");
        }
    }
}