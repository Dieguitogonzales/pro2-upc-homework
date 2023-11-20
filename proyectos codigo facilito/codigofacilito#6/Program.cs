using System;

namespace CodigoFacilitoVideo6
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasEmpleados empleado;
            empleado = new ClasEmpleados();
            empleado.Edad = 25;
            empleado.Nombres = "Marcos Hernandez";
            empleado.SueldoDiario = 12.5m;

            decimal total;
            total = empleado.CalculaSalario(30);

            Console.WriteLine("El salario mensual del empleado " + empleado.Nombres);
            Console.WriteLine("es: " + total.ToString("c"));

            Console.ReadKey();
        }
    }

    class ClasEmpleados
    {
        public string Nombres { get; set; }
        public int Edad { get; set; }
        public decimal SueldoDiario { get; set; }

        public decimal CalculaSalario(int diasTrabajados)
        {
            return SueldoDiario * diasTrabajados;
        }
    }
}