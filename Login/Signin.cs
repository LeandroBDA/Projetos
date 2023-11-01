namespace Login;

public class Signin
{
    public void SigninUser()
    {
        Console.Clear();
        Console.WriteLine("Realize seu Cadastro.");
        Console.WriteLine("Nome do usuário:");
        string username = Console.ReadLine();
        Console.WriteLine("Senha:");
        string password = Console.ReadLine();

        var newUser = new User(username, password);
        
        Program.users.Add(newUser);
        Console.WriteLine("Usuário Cadastrado com Sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
        var backMenu = new myMenu();
        backMenu.Menu();
    }
}