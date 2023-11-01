namespace Treinamento;

public class pessoa
{
     public string Nome;
    public int Idade;

    public void Falar()
    {
        Console.WriteLine("Olá, meu nome é " + Nome + " e eu tenho " + Idade + " anos.");
    }
}
}