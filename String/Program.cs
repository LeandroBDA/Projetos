using System;
namespace String;

public class String
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Iforme seu nome completo");
        string nome = Console.ReadLine();
        
        Console.Clear();
        Console.WriteLine(nome.Trim());
        Console.WriteLine(nome.Replace(" ",""));
        Console.WriteLine(nome.ToUpper());
        Console.WriteLine(nome.Insert(nome.Length, "Leo"));
        Console.WriteLine(nome.Replace("nome", ""));
        Console.WriteLine(nome.Contains("nome"));
        Console.WriteLine(nome.Replace("" , "").Length);
    }
}