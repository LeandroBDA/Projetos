using System;

namespace MediaAri;

public class MediaAri
{
    public static void Main(string[] args)

    {
        inicio:
        
        Console.WriteLine("Informe o primeiro valor");
        int nota1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Informe a segunda nota");
        int nota2 = int.Parse(Console.ReadLine());

        float media = ((float)nota1 + nota2) / 2;
        
        Console.WriteLine($"A media de {nota1} e {nota2} é = {media}");
        
        Console.WriteLine("Aperte qualquer tecla para reiniciar");
        Console.ReadKey();
        Console.Clear();
        goto inicio;
    }
        
}


