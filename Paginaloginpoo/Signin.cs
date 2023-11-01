using System.Net.Sockets;

namespace Paginaloginpoo;

public class Signin
{
    public void SigninUser()
    {
        Console.Clear();
        
        Console.WriteLine("[_REALIZE_SEU_CADASTRO_]");
        Console.Write("[_NOME_DO_USUÁRIO:_]:");
        string username = Console.ReadLine();
        Console.Write("[_SENHA:_]");
        string password = Console.ReadLine();

        var newUser = new User(username, password);
        
        // newUser.Username = username;
        // newUser.Password = password;
        
        Program.users.Add(newUser);
        Console.WriteLine("[_USUÁRIO_CADASTRADO_COM_SUCESSO!_]");
        Thread.Sleep(4000);
        Console.Clear();
        var backMenu = new myMenu();
        backMenu.MenuShow();
    }
}