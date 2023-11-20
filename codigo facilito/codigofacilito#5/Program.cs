using System;

namespace CodigoFacilitoVideo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = ObtenerValor("Dame el primer valor:");
            int valor2 = ObtenerValor("Dame el segundo valor:");

            Comparador.CompararValores(valor1, valor2);

            Console.ReadKey();
        }

        static int ObtenerValor(string mensaje)
        {
            Console.WriteLine(mensaje);
            string cadena = Console.ReadLine();
            return Convert.ToInt32(cadena);
        }
    }
}
