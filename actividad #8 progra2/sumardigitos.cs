using System;

public class ArrayNum
{
    public int[] Numeros;

    // CONSTRUCTOR
    public ArrayNum()
    {
        Numeros = new int[0];
    }

    public ArrayNum(int valor)
    {
        Numeros = new int[valor];
    }

    public void MostrArarray()
    {
        for (int i = 0; i < Numeros.Length; i++)
        {
            Console.WriteLine(Numeros[i]);
        }
    }

    public void SumarDig()
    {
        int sum = 0;
        int n = Numeros.Length;
        for (int i = 0; i <= n - 1; i++)
        {
            sum = sum + Numeros[i];
        }
        Console.WriteLine(sum);
    }

    public static void MostrarMaxMinArrayEnteros(int[] array)
    {
        // Mostrar el array
      

        // Inicializar variables para almacenar el máximo y el mínimo
        int maximo = array[0];
        int minimo = array[0];

        // Iterar sobre el array para encontrar el máximo y el mínimo
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maximo)
            {
                maximo = array[i];
            }

            if (array[i] < minimo)
            {
                minimo = array[i];
            }
        }

        // Mostrar el máximo y el mínimo en la consola
        Console.WriteLine("Número máximo: " + maximo);
        Console.WriteLine("Número mínimo: " + minimo);
    }
    public class Entero{

     public int N = 0; 

    //constructor
    public  Entero(){
            N = 0;
        

    }

    public  Entero(int num){
        N = num;
    }
    //metodos (procedimientos/ funciones)
     public bool EsPar()
    {
        if (N % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public bool Espar_Mejorado(){
        return (N % 2 == 0);

    }
    public bool EsMultiploN(int multiplo){
        return (N % multiplo == 0);
    }
    public void MostrarDigitos(){
         int NroAux = N;
        while (NroAux != 0)
        {
            int dig = NroAux % 10;
            Console.WriteLine("Dig: " + dig);
            NroAux = NroAux / 10;
        }
    }
}
}


