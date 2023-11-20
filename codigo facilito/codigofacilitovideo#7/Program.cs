using System;
using clase7;

namespace presentacion7
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ClsEmpleados empleado;
            empleado = new ClsEmpleados();
            empleado.Edad = 25;
            empleado.Nombre = "marcos hernandez";
            empleado.SueldoDiario = 12.5m;
            decimal total;
            total = empleado.CalcularSalario(30);
            Console.WriteLine("EL SALARIO MENSUAL DEL EMPLEADO " + empleado.Nombre);
            Console.WriteLine("es: " + total.ToString("C"));
            Console.ReadKey();




        }
    }
}
