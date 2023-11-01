namespace SuperHeroAPI;

public class SuperHEro
{
    public int Id { get; set; } // Identificação inicial int porque usa numeros reais...
   
    public int MyProperty { get; set; } // Tipo de propriedade
    
    public string Name { get; set; } = string.Empty; // Nome de Heroi

    public string FirstName { get; set; } = string.Empty; // Nome usual
   
    public string LastName { get; set; } = string.Empty; // Ultimo nome
    
    public string Place { get; set; } = string.Empty; // Lugar de nascimento
}