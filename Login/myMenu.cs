using System.Threading.Channels;

namespace Login;

public class myMenu
{
    public void Menu()
    {
        Console.WriteLine("===== Pagina de Login =====");
        Console.WriteLine("(1) - Login");
        Console.WriteLine("(2) - Cadastro");
        Console.WriteLine("(0) - Para Sair");
        string option = Console.ReadLine();

        switch (option)
        {
            case "1" : var login = new myLogin(); login.LoginUser(); break;
            case "2" : var cadastro = new Signin(); cadastro.SigninUser(); break;
            case "0" : Console.WriteLine("O programa vai ser encerrado! Volte Sempre."); Thread.Sleep(4000); 
                Environment.Exit(0); break;
            
            default: Console.WriteLine("Opção invalida! Tente Novamente.");
                Thread.Sleep(4000);
                Console.Clear();
                Menu();
                break;
        }
    }
}