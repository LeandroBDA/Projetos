using System;

namespace Teste;

public class Teste
{
    public static void Main(string[] args)
    {
        Carro meuCarro = new Carro();
        meuCarro.Modelo = "Camaro";
        meuCarro.Ano = 1969;
        meuCarro.Portas = 2;
        meuCarro.Ligar();
        meuCarro.Acelerar();
        Console.WriteLine("Modelo: " + meuCarro.Modelo);
        Console.WriteLine("Ano: " + meuCarro.Ano);
        Console.WriteLine("Portas: "+ meuCarro.Portas);

    }
    
    public class Veiculo
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public void Ligar()
        {
            Console.WriteLine("O veiculo foi ligado.");
        }
    }
    public class Carro : Veiculo
    {
        public int Portas { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("O carro está acelerando.");
        }
    }
}

   