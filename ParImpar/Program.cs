using System;

namespace ParImpar;

public class ParImpar
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Informe um Número Inteiro: ");
       int num = int.Parse(Console.ReadLine());

       if (num / 2 == 0)
       {
           Console.WriteLine($"O numero {num} é par");
       }
       else
       {
           Console.WriteLine($"O numero {num} é impar");
       }
    }  
}

