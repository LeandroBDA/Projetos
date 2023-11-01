namespace CalculatorPOO;

public class Subtração
{
    public void subtração()
    {
        Console.WriteLine("INFOME O PRIMEIRO VALOR:");
        var X = decimal.Parse(Console.ReadLine());
        Console.WriteLine("INFORME O SEGUNDO VALOR:");
        var Y = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"A SUBTRAÇÃO DE {X} E {Y} É {X - Y}:");
        Thread.Sleep(3000);
        Console.ReadLine();
        var backMenu = new Menu();
        backMenu.myMenu();
    }
}