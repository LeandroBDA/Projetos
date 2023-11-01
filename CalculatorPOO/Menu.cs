using System.Threading.Channels;

namespace CalculatorPOO;

public class Menu
{
    public void myMenu()
    {
        Console.WriteLine("O QUE DESEJA FAZER?");
        Console.WriteLine("[1] - SOMA:");
        Console.WriteLine("[2] - DIVISÃO:");
        Console.WriteLine("[3] - SUBTRAÇÃO:");
        Console.WriteLine("[4] - MULTIPLICAÇÃO:");
        Console.WriteLine("[0] - SAIR:");
        string option = Console.ReadLine();

         switch (option)
        {
             case "1" : var soma = new soma(); soma.Soma(); break;
             case "2" : var div = new Divisão(); div.divisão(); break;
             case "3" : var sub = new Subtração(); sub.subtração(); break;
             case "4" : var mult = new Multiplicação(); mult.multiplicação(); break;
             case "0" : Console.WriteLine("OBRIGADO, ATÉ LOGO!"); 
                 Thread.Sleep(3000); 
                 Environment.Exit(0); break;
             
             default : Console.WriteLine("OPÇÃO INVALIDA, TENTE NOVAMENTE!:"); 
                 Thread.Sleep(3000); 
                 myMenu(); break; 
        }
    }
}