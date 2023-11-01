using System;

namespace Treinamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro("Chev", ano:1969 , "Azul");
            meuCarro.ImprimirDados();
        }
    }

    public class Carro
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }

        public Carro(string modelo, int ano, string cor)
        {
            Modelo = modelo;
            Ano = ano;
            Cor = cor;
        }

        public void ImprimirDados()
        {
            Console.WriteLine("Modelo:" + Modelo);
            Console.WriteLine("Ano:" + Ano);
            Console.WriteLine("Cor:" + Cor);
        }
    }
}




