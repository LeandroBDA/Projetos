namespace Paginaloginpoo;

public class MYlogin
{
    public void LoginUser()
    {
        if (Program.users.Count == 0)
        {
            Console.WriteLine("[_NÃO_EXISTEM-USUÁRIOS_CADASTRADOS._POR_FAVOR_FAÇA_SEU_CADASTRO_]");
            Thread.Sleep(4000);
            Console.Clear();
            var singin = new Signin();
            singin.SigninUser();
        }

        else
        {
            Console.WriteLine("[_REALIZE_O_LOGIN._]");
            Console.Write("[_NOME_DO_USUÁRIO:_]:");
            string username = Console.ReadLine();
            Console.Write("[_SENHA:_]:");
            string password = Console.ReadLine();

            foreach (User user in Program.users)
            {
                if (user.Username == username && user.Password == password)
                {
                    Console.WriteLine("[_LOGIN_BEM_SUCEDIDO!_]");
                }
                else
                {
                    Console.WriteLine("[_NOME_DO_USUÁRIO_OU_SENHA_INCORRETOS. POR_FAVOR_TENTE_NOVAMENTE._]");
                    LoginUser();
                    
                }
            }
        }
    }
}