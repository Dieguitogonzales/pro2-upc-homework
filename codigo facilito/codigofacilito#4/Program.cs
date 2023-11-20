using System;

namespace CodigoFacilitoVideo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            decimal x = 12.2m;
            bool bandera = false;
            string cadena = string.Empty;
            DateTime fecha = DateTime.MinValue;

            Console.WriteLine("El valor de i es: {0}", i);
            Console.WriteLine("El valor de x es: {0:c}", x);
            Console.WriteLine("El valor de bandera es: " + bandera.ToString());
            Console.WriteLine("El valor de cadena: " + cadena);
            Console.WriteLine("El valor de fecha: " + fecha.ToShortDateString());

            Console.ReadKey();
        }
    }
}
