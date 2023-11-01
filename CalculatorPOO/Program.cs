using System;

namespace CalculatorPOO;

public static class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OLÁ, SEJA BEM-VINDO!");
        Thread.Sleep(4000);
        Console.Clear();
        var myMenu = new Menu();
        myMenu.myMenu();
    }
}

