namespace ClaseEntero
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayNum A = new ArrayNum(4);
            A.Numeros[0] = 2;
            A.Numeros[1] = 8;
            A.Numeros[2] = 3;
            A.Numeros[3] = 6;
            A.MostrArarray();
            Console.WriteLine("la suma de los numeros es: ");
            A.SumarDig();
            Console.WriteLine("--------------------------------------");
            int[] arrayEnteros = { 5, 3, 8, 1, 9, 2, 7 };

            // Llamar al método para mostrar el máximo y el mínimo
            ArrayNum.MostrarMaxMinArrayEnteros(arrayEnteros);
            Console.WriteLine("------------------------");
            

            //Entero Nro = new Entero(14);
            //Nro.N = 243111138;
            //Console.WriteLine("N: " + Nro.N);
            //bool res = Nro.Espar_Mejorado();
            //bool res = Nro.EsMultiploN(2);
            //Console.WriteLine("EsMultiploN: " + res);

            //Nro.MostrarDigitos();
            //Nro.MostratDigitosPares();

           // Cadena C = new Cadena("Console.WriteLine");
           // Console.WriteLine("Cadena: " + C.Cad);

            //char caracter = C.ObtenerCaracter(3);
            //Console.WriteLine("Char: " + caracter);

           // C.MostraCaracteres();
}
}

}
