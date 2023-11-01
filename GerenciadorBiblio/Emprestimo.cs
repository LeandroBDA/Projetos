namespace Biblioteca;

public class Emprestimo
{
    public Emprestimo(User user, Books books, DateOnly dataEmprestimo, DateOnly dataDevolução)
    {
        User = user;
        Books = books;
        DataEmprestimo = dataEmprestimo;
        DataDevolução = dataDevolução;
    }

    public User User { get; set; }
    
    public Books Books { get; set; }
    
    public DateOnly DataEmprestimo { get; set; }
    
    public DateOnly DataDevolução { get; set; }
}