
using System;

class Program {
    static void Main(string[] args)

    {
        inicio:
        Console.Write("Digite a quantidade de valores: ");
        int n = int.Parse(Console.ReadLine());

        double soma = 0;

        for (int i = 0; i < n; i++) {
            Console.Write("Digite o " + (i+1) + " valor: ");
            double valor = double.Parse(Console.ReadLine());
            soma += valor; }

        double media = soma / n;

        Console.WriteLine("A média aritmética dos " + n + " valores é: " + media);
        Console.ReadKey();
        Console.Clear();
        goto inicio;
    }
}
