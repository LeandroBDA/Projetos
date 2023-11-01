namespace Calculator;

public class Calculator
{
    public static void Main(string[] args)
    {
       Menu();
    }

    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Qual opção deseja?");
        Console.WriteLine("0- Sair");
        Console.WriteLine("1- SOMA");
        Console.WriteLine("2- DIVISÃO");
        Console.WriteLine("3- SUBTRAÇÃO");
        Console.WriteLine("4- MULTIPLICAÇÃO");
        var opção = int.Parse(Console.ReadLine());

        switch (opção)
        {
            case 0: System.Environment.Exit(0); break;
            case 1: Soma(); break;
            case 2: Divisao(); break;
            case 3: Subtracao(); break;
            case 4: Multiplicacao(); break;
            default: Menu(); break;
        }
    }

    public static void Soma()
    {
        Console.Clear();
        Console.WriteLine("Informe o primeiro numero: ");
        var x = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero: ");
        var y = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"A soma de {x} e {y} é {x + y}");
        System.Threading.Thread.Sleep(3000);
        Menu();
    }
    
    public static void Divisao()
    {
        Console.Clear();
        Console.WriteLine("Informe o primeiro numero: ");
        var x = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero: ");
        var y = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"A Subtracao de {x} e {y} é {x / y}");
        System.Threading.Thread.Sleep(3000);
        Menu();
    }
    
    public static void Subtracao()
    {
        Console.Clear();
        Console.WriteLine("Informe o primeiro numero: ");
        var x = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero: ");
        var y = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"A soma de {x} e {y} é {x - y}");
        System.Threading.Thread.Sleep(3000);
        Menu();
    }
    
    public static void Multiplicacao()
    {
        Console.Clear();
        Console.WriteLine("Informe o primeiro numero: ");
        var x = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero: ");
        var y = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"A subtração de {(float)x} e {y} é {x * y}");
        System.Threading.Thread.Sleep(3000);
        Menu();
    }
}