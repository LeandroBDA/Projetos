namespace Teste;

public class Carro
{
    public static void Main(string[] args)
    {
        Carro meuCarro = new Carro();
        meuCarro.Modelo = "Camaro";
        meuCarro.Ano = 1968;
        meuCarro.Portas = 2;
        meuCarro.Ligar();
        meuCarro.Acelerar();
        Console.WriteLine("Modelo: " + meuCarro.Modelo);
        Console.WriteLine("Ano: " + meuCarro.Ano);
        Console.WriteLine("Portas: "+ meuCarro.Portas);

    }
}