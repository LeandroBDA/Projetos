namespace Biblioteca;

public class Books
{
    public string Titulo { get; set; }
   
    public string NomeAutor  { get; set; }
    
    public string AnoPubli { get; set; }

    public Books(string titulo, string autor, string anoPubli)
    {
        Titulo = titulo;
        NomeAutor = autor;
        AnoPubli = anoPubli;
    }
}