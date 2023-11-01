namespace MaiorEMeorNumero;

public class MaiorEMeorNumero
{
    public static void Main(string[] args)
    {
       
        Console.WriteLine("Informe o primeiro numero");
        double num1 = double.Parse(Console.ReadLine());
        
       
        Console.WriteLine("Informe o segundo numero");
        double num2 = double.Parse(Console.ReadLine());
        
       
        Console.WriteLine("Informe o terceiro numero");
        double num3 = double.Parse(Console.ReadLine());
        
        
        double maiorValor = 0;

        if (num1 > num2 && num1 > num3)
        {
            maiorValor = num1;
        } else if (num2 > num1 && num2 > num3)
        {
            maiorValor = num2;
        }
        else
        {
            maiorValor = num3;
        }
        
        double menorValor = 0;

        if (num1 < num2 && num1 < num3)
        {
            menorValor = num1;
        } else if (num2 < num1 && num2 < num3)
        {
            menorValor = num2;
        }
        else
        {
            menorValor = num3;
        }
        Console.WriteLine($"O maior valor entre {num1}, {num2} e {num3} é {maiorValor}");
        Console.WriteLine($"O menor valor entre {num1}, {num2} e {num3} é {menorValor}");
    }
}

    