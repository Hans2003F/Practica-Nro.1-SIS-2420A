using System;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> lis_orig = new List<int>();
        List<int> lis_multiplos2 = new List<int>();
        List<int> lis_Primos = new List<int>();
        List<int> lis_multiplos5 = new List<int>();
        List<int> lis_Perfectos = new List<int>();
        uint n;
        Console.WriteLine("INGRESE LA CANTIDAD DE DATOS QUE DESEE INGRESAR A LA LISTA");
        n=(uint)Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese " + n + " a la lista");
        for(int i = 0; i < n; i++)
        {
            lis_orig.Add(Convert.ToInt32(Console.ReadLine()));
        }
        Console.Write("lista original: " );
        foreach (int i in lis_orig)
        {
            Console.Write(i+"  ");
        }
        //para la lista de multiplos de 2
        Console.WriteLine();
        foreach (int i in lis_orig)
        {
            if(i%2 == 0) lis_multiplos2.Add(i);
            if(primos(i)) lis_Primos.Add(i);
            if (i % 5 == 0) lis_multiplos5.Add(i);
            if(perfectos(i)) lis_Perfectos.Add(i);
        }
        Console.Write("lista de multiplos de dos :" );
        foreach (int i in lis_multiplos2)
        {
            Console.Write(i+"  ");
        }
        Console.WriteLine();
        //para lista de numeros primos
        Boolean primos(int a)
        {
            for (int i = 2; i <= a / 2; i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
        Console.Write("lista de primos es: ");
        foreach (int i in lis_Primos)
        {
            Console.Write(i+"  ") ;
        }
        Console.WriteLine();
        //para multiplos de 5
        Console.Write("lista de multiplos de cinco: ");
        foreach(int i in lis_multiplos5)
        {
            Console.Write(i+"  ") ;
        }
        Console.WriteLine();
        //para los perfectos
        Boolean perfectos(int a)
        {   int r=0 ;
            for(int i=1; i < a ; i++)
            {
                if (a % i == 0)
                    r += i;
            }
            return r == a;
        }
        Console.Write("lista de perfectos: ");
        foreach(int i in lis_Perfectos)
        {
            Console.Write(i+"  ") ;
        }
    }
}