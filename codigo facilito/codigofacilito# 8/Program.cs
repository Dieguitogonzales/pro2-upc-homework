namespace clase8
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsClientesVentas Cliente;
            Cliente = new ClsClientesVentas();
            Cliente.IdCliente = 123;
            Cliente.Apellidos = "Hernandez Hernandez";
            Cliente.Nombres = "Marcos";
            Cliente.RFC = "HEHM"; // Corregir aquí, falta el signo de igual (=)
            Cliente.Direccion = "av tigre 122";
            Cliente.Colonia = "la cueva del jaguar"; // Corregir aquí, eliminé un espacio extra
            Cliente.Municipio = "tuxtla gutierrez";
            Cliente.EsCredito = true;
            Console.WriteLine(Cliente.Apellidos + " " + Cliente.Nombres);
            Console.WriteLine(Cliente.Direccion + " " + Cliente.Colonia);
            Console.WriteLine(Cliente.RFC);
            if (Cliente.EsCredito)
                Console.WriteLine("el cliente tiene credito");
            else
                Console.WriteLine("el cliente no tiene credito");
            Console.ReadKey();
        }
    }
}