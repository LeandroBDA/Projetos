using System.Threading.Channels;

namespace Paginaloginpoo;

public class myMenu
{
    public void MenuShow()
    {
        Console.WriteLine("[___BEM-VINDO!_ESCOLHA_UMA_OPÇÃO:]");
        Console.WriteLine("[--------------------------]");
        Console.WriteLine("[__(1)_FAÇA_SEU_LOGIN______]");
        Console.WriteLine("[--------------------------]");
        Console.WriteLine("[__(2)_FAÇA_SEU_CADSTRO____]");
        Console.WriteLine("[--------------------------]");
        Console.WriteLine("[__PARA_SAIR_DIGITE_(0)____]");
        Console.WriteLine("[--------------------------]");
       
        string option = Console.ReadLine();

        switch (option)
        {
            case "1":
                var login = new MYlogin();
                login.LoginUser();
                break;
            case "2":
                var signin = new Signin();
                signin.SigninUser();
                break;
            case "0":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("[_OPÇÃO_INVALIDA!_TENTE_NOVAMENTE._]");
                Thread.Sleep(4000);
                Console.Clear();
                MenuShow();
                break;
        }
    }
}