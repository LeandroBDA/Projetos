using System;
using System.ComponentModel.Design;
using System.IO.Pipes;
using System.Threading.Channels;
//CÓDIGO COM ALGUMAS FALHAS, MAS FUNCIONANDO CORRETAMENTE.
namespace Biblioteca;

public class Program
{
    public static List<Books> books = new List<Books>();
    public static List<User> users = new List<User>();
    public static List<Emprestimo> Emprestimos = new List<Emprestimo>();
    public static void Main(string[] args)
    {
        Menu();
    } 
    public static void Menu()
    {
        Console.WriteLine("BEM-VINDO AO SISTEMA DE GERENCIAMENTO DE BIBLIOTECA!");
        Console.WriteLine("=====SELECIONE UMA OPÇÃO=====");
        Console.WriteLine("[1] - CADASTRAR UM LIVRO:  ");
        Console.WriteLine("[2] - EXIBIR LIVROS DISPONÍVEIS: ");
        Console.WriteLine("[3] - REALIZAR EMPRESTIMO: ");
        Console.WriteLine("[4] - REGISTRAR DEVOLUÇÃO: ");
        Console.WriteLine("[5] - CADASTRAR USUÁRIO: ");
        Console.WriteLine("[0] - SAIR");
        string option = Console.ReadLine();
        
        switch (option)
        {
            case "1" : Console.Clear(); Thread.Sleep(1000); CadastrarLivro(); break;
            case "2" : Console.Clear(); Thread.Sleep(1000); LivrosDisponiveis(); break;
            case "3" : Console.Clear(); Thread.Sleep(1000); Emprestimo(); break;
            case "5" : Console.Clear(); Thread.Sleep(1000); Cadastro(); break;
            case "0" : Environment.Exit(0); break;
        }
    }
    public static void CadastrarLivro()
    {
        Console.Write("INFORME O TÍTULO DO LIVRO: ");
        string titulo = Console.ReadLine();
        Console.Write("INFORME O AUTOR SO LIVRO: ");
        string autor = Console.ReadLine();
        Console.Write("INFORME O ANO DE BUBLICAÇÃO: ");
        string anoPubli = Console.ReadLine();
        
        var NewBook = new Books(titulo, autor, anoPubli);
        books.Add(NewBook);
        Console.WriteLine("LIVRO CADASTRADO COM SUCESSO!");
        Thread.Sleep(3000); Console.Clear();
        Menu();

    }
    public static void LivrosDisponiveis()
    {
        Console.WriteLine("LIVROS DISPONÍVEIS NO MOMENTO.\n");
        
        foreach (var book in books)
        {
            Console.WriteLine($"TITULO: [{book.Titulo}] AUTOR: [{book.NomeAutor}]  ANO DE PUBLICAÇÃO: [{book.AnoPubli}]");
        }
        Console.WriteLine();
        Console.WriteLine("[0] - VOLTAR");
        string escolha = Console.ReadLine();
       
        switch (escolha)
        {
            case "0" : Console.Clear(); Menu(); break;
            
            default: Console.WriteLine("OPÇÃO INVÁLIDA, TENTE NOVAMENTE"); 
                Thread.Sleep(3000);
                Console.Clear();
               LivrosDisponiveis(); break; 
        }
    }
    
    //ERRO NA CLASSE EMPRESTIMO, NÃO CONSEGUI REALIZAR O ALUGUEL DO LIVRO
    public static void Emprestimo()
    {
        
        Console.WriteLine("QUAL LIVRO DESEJA ALUGAR?");
        Console.Write("TÍTULO: ");
        string nome = Console.ReadLine();
        var book = books.Find(x => x.Titulo == nome);
        if (book == null)
        {
            Console.WriteLine("ACHAMO O LIVRO NÃO, OH. VÁ PRA CASA");
            Thread.Sleep(3000); Console.Clear(); Menu();
        }
        Console.ReadLine();
        Console.WriteLine($"TITULO: [{book.Titulo}] AUTOR: [{book.NomeAutor}]  ANO DE PUBLICAÇÃO: [{book.AnoPubli}]");
        Console.WriteLine("LIVRO DISPONIVEL, DESEJA ALUGAR?");
        Console.WriteLine("[1] - SIM");
        Console.WriteLine("[0] - NÃO");
        string optione = Console.ReadLine();
        
        
        switch (optione)
        {
            case "1" : Alugar(book); break;
        }
        
        if (books.Count == 0)
        {
            Console.WriteLine("NENHUM LIVRO CADASTRADO, POR FAVOR CADASRE UM LIVRO!");
            Thread.Sleep(3000); Console.Clear();
            Console.WriteLine("[1] - EMPRESTIMO.");
            Console.WriteLine("[0] - PARA VOLTAR PARA O MENU PRINCIPAL.");
            string option = Console.ReadLine();
            Console.ReadLine();
           
            switch (option)
            {
                case "1" : Emprestimo(); break;
                case "0" : Menu(); break;
            }
        }
        var Books = books.Find(x => x.Titulo == nome);

        if (Books == null)
        {
            Console.WriteLine("LIVRO NÃO ENCONTRADO.");
            Thread.Sleep(3000); Console.Clear();
            Console.WriteLine("[1] - VOLTAR.");
            Console.WriteLine("[0] - PARA VOLTAR PARA O MENU PRINCIPAL.");
            string option = Console.ReadLine();
            Console.ReadLine();
           
            switch (option)
            {
                case "1" : Emprestimo(); break;
                case "0" : Menu(); break;
            }
        }
        if (users.Count == 0)
        {
            Console.Clear();
            Console.WriteLine("NENHUM USUÁRIO ENCONTRADO. DESEJA CADASTRA - SE?");
            Console.WriteLine("DIGITE [Y] MAISCULO PARA SIM.");
            Console.WriteLine("DIGITE [0] PARA SAIR.");
            string option = Console.ReadLine();
            Console.Clear();
           
            switch (option)
           
            {
                case "Y" : Cadastro(); break;
                
                case "0" : Environment.Exit(0); Console.Clear(); break;
                
                default: Console.WriteLine("OPÇÃO INVÁLIDA, POR FAVOR TENTE NOVAMENTE.");
                    Thread.Sleep(3000); Console.Clear(); Menu(); break;
            }
        }
    } 
    public static void Cadastro()
    {
        Console.WriteLine("BEM-VINDO AO CADASTRO, PARA CONTINUAR INFORME OS DADOS ABAIXO");
        Console.Write("NOME COMPLETO: ");
        string usarname = Console.ReadLine();
        Console.Write("SENHA:");
        string password = Console.ReadLine();
        Console.Clear();
        var user = new User(usarname, password);
        Program.users.Add(user);
        Console.WriteLine("USUÁRIO CADASTRADO COM SUCESSO");
        Thread.Sleep(3000);
        Console.Clear(); Menu(); 
    } 
    
    //FALTA A PARTE DE DEVOLUÇÃO E DATAS DE EMPRESTIMO E DEVOLUÇÃO.
    public static void Alugar(Books book)
    {
        Console.Clear();
        Console.WriteLine("USUÁRIO: ");
        string usarname = Console.ReadLine();
        Console.WriteLine("SENHA: ");
        string password = Console.ReadLine();
        string livroAlugado = Console.ReadLine();
        Thread.Sleep(3000); Console.Clear();
       
        if (users.Count == null)
        {
            Console.WriteLine("UAUÁRIO NÃO ENCONTRADO, POR FAVOR CADASTRE-SE.");
            Thread.Sleep(3000); Console.Clear();
            Menu();
        }
       
        if (livroAlugado != null)
        {
            Console.WriteLine("LIVRO ALUGADO COM SUCESSO!");
            Thread.Sleep(3000); Console.Clear();
            Console.WriteLine("\n.Livros disponíveis após o aluguel:");
            foreach (var Books in books)
            {
                Console.WriteLine($"TITULO: [{book.Titulo}] AUTOR: [{book.NomeAutor}]  ANO DE PUBLICAÇÃO: [{book.AnoPubli}]");
            }
        }
        else
        {
            Console.WriteLine("LIVRO NÃO ENCONTRADO OU NÃO DISPONÍVEL");
            Thread.Sleep(3000); Console.Clear(); Menu();
        }
    }
}
