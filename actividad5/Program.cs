
using System.Data.Common;
using System.Net.Mail;

namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Asistencias MyAsistencias = new Asistencias();
        MyAsistencias.asignarCarrera("ing. de sistemas");
         Console.WriteLine(MyAsistencias.carrera);
         MyAsistencias.asignarMateria("programacionII");
         Console.WriteLine(MyAsistencias.materia);
         MyAsistencias.asignarDocente("EDDY ESCALANTE");
         Console.WriteLine(MyAsistencias.docente);
         


        
    }
}