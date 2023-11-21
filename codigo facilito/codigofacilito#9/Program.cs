using System;

namespace Presentacion7
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesBase cliente = new clsClientesBase(1, "Marcos Hernandez", "001", "HEHM", 1, "Marcos Hernandez");
            Console.WriteLine(cliente.Clave + " " + cliente.Nombre);
            Console.WriteLine(cliente.TipoRegimen);
            Console.WriteLine(cliente.RFC);
            Console.ReadKey();
        }
    }
}