using System;
using System.IO.Pipes;

namespace Concessionária;

public class Program
{
    public static List<Veiculo> veiculos = new List<Veiculo>();
    public static List<Veiculo> veiculosVendidos = new List<Veiculo>();

    public static void Main(string[] args)
    {
        Menu();
    }
    public static void Menu()
    {
        Console.WriteLine("[1]-Cadastrar Veiculo");
        Console.WriteLine("[2]-Listar Veiculos Disponíveis");
        Console.WriteLine("[3]-Vender Veiculos");
        Console.WriteLine("[4]-Listar Veiculos Vendidos");
        Console.WriteLine("[0]-Sair");
        string opition = Console.ReadLine();

        switch (opition)
        {
            case "1" : Console.Clear(); CadastrarVeiculo(); break;
            case "2" : Console.Clear(); VeiculosDisponiveis(); break;
            case "3" : Console.Clear(); VenderVeiculos(); break;
            case "4" : Console.Clear(); VeiculosVendidos(); break;
            case "0" : Environment.Exit(0); break;
        }
    } 
    public static void CadastrarVeiculo()
    {
        Console.Write("Informe o Nome do Automovél: ");
        string automovel = Console.ReadLine();
        Console.Write("Informe a Marca: ");
        string marca = Console.ReadLine();
        Console.Write("Informe o Modelo: ");
        string modelo = Console.ReadLine();
        Console.Write("Informe o Ano: "); ;
        int ano = int.Parse(Console.ReadLine());
        Console.Write("Informe o Preço: ");
        string preço = Console.ReadLine();

        var NewVeiculo = new Veiculo(automovel, marca, modelo, ano, preço); 
        Program.veiculos.Add(NewVeiculo);
        Console.WriteLine("Veiculo Adicionado com Sucesso."); 
        Thread.Sleep(2000);
        Console.Clear();
        Menu();
    }

    public static void VeiculosDisponiveis()
    {
        Console.WriteLine("Vaículos Disponíveis no Momento:");
        
        foreach (var veiculo in veiculos)
        {
            Console.WriteLine($"Automóvel: [{veiculo.AutoMovel}] Marca: [{veiculo.Marca}] Modelo: [{veiculo.Modelo}] Ano: [{veiculo.Ano}] Preço: [{veiculo.Preço}]");
        }
       
        Console.WriteLine();
        Console.WriteLine("[0] - VOLTAR");
        string escolha = Console.ReadLine();
       
        switch (escolha)
        {
            case "0" : Console.Clear(); Menu(); break;
            
            default: Console.WriteLine("OPÇÃO INVÁLIDA, TENTE NOVAMENTE"); 
                Thread.Sleep(3000); 
                Console.Clear(); Menu(); break; 
        }
    } 
    public static void VenderVeiculos()
    {
        Console.WriteLine("Vaículos Disponíveis para Venda: ");
        
        foreach (var veiculo in veiculos)
        {
            Console.WriteLine($"Automóvel: [{veiculo.AutoMovel}] Marca: [{veiculo.Marca}] Modelo: [{veiculo.Modelo}] Ano: [{veiculo.Ano}] Preço: [{veiculo.Preço}]");
            Console.WriteLine();
        }
        Console.WriteLine("Qual Veiculo Deseja Comprar?");
        string nomeVeiculo = Console.ReadLine();
        var veiculoComprar = veiculos.Find(x => x.Modelo == nomeVeiculo);

        if (veiculoComprar == null)
        {
            Console.WriteLine("Por favor, selecione um veículo primeiro.");
            Console.WriteLine("[0]- Para voltar");
            Thread.Sleep(3000); Console.Clear();
            string backmenu = Console.ReadLine();
            switch (backmenu)
            {
                case "0" : Console.Clear(); Menu(); break;
            }
        }
        
        veiculosVendidos.Add(veiculoComprar);
        veiculos.Remove(veiculoComprar);
        Console.WriteLine("Veiculo Vendido!");
        Thread.Sleep(3000);
        Console.Clear(); Menu();
    }
    public static void VeiculosVendidos()
    {
        if (veiculosVendidos.Count == 0)
        {
            Console.WriteLine("Nenhum Veiculo Vendido, tente novamente após uma venda.");
            Thread.Sleep(3000);
            Console.Clear();
            Menu();
        }
        
        foreach (var veiculo in veiculosVendidos)
        {
            Console.WriteLine("Veicuolos vendidos no momento: ");
            Console.WriteLine($"Automóvel: [{veiculo.AutoMovel}] Marca: [{veiculo.Marca}] Modelo: [{veiculo.Modelo}] Ano: [{veiculo.Ano}] Preço: [{veiculo.Preço}]");
            Console.WriteLine();
            Console.WriteLine("[0]- Voltar para o Menu.");
            string option = Console.ReadLine();

            switch (option)
            {
                case "0": Console.Clear(); Menu(); break;
            }
        }
    }       
}

