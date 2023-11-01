namespace Biblioteca;

public class User
{
    public User(string nome, string password)
    {
        Nome = nome;
        Password = password;
    }

    public string Nome { get; set; }
    public string Password { get; set; }
}