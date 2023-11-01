namespace Login;

public class myLogin
{
    public void LoginUser()
    {
        if (Program.users.Count == 0)
        {
            Console.WriteLine("Não existem usuários cadastrados. Por favor faça seu cadastro.");
            Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine("Deseja fazer seu cadastro?");
            Console.WriteLine("(Y) Para sim");
            Console.WriteLine("(N) Para não");
            string option = Console.ReadLine();
            
            switch (option)
            {
                case "Y" : var cadastro = new Signin(); cadastro.SigninUser(); break;
                case "N" : Environment.Exit(0); break;
            }
            var signin = new Signin();
             signin.SigninUser();
        }
        else
        {
            Console.WriteLine("Realize o Login.");
            Console.Write("Nome do Usuário:");
            string usarname = Console.ReadLine();
            Console.WriteLine("Senha:");
            string password = Console.ReadLine();

            foreach (User user in Program.users)
            {
                if (user.Username == usarname && user.Password == password)
                {
                    Console.WriteLine("Login Bem Sucedido!");
                }
                else
                {
                    Console.WriteLine("Nome do usuário ou senha Incorretos. Por favor Tente Novamente.");
                    Thread.Sleep(4000);
                    Console.Clear();
                    LoginUser();
                }
            }
        }
    }
}