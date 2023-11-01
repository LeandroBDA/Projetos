namespace Biblioteca;

public class Biblioteca
{
    public Biblioteca(string nameBook, bool empres, List<Books> books)
    {
        NameBook = nameBook;
        Empres = empres;
        Books = books;
    }

    public string NameBook { get; set; }
    public bool Empres { get; set; }
    public List<Books> Books { get; set; }
    
}