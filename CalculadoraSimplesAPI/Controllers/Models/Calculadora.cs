namespace CalculadoraSimplesAPI.Controllers.Models;

public class Calculadora
{
    public double Valor1 { get; set; }
    public double Valor2 { get; set; }
    
    public double Resultado { get; set; }

    public Calculadora(){}
    
    
    public Calculadora(double valor1, double valor2)
    {
        Valor1 = valor1;
        Valor2 = valor2;
    }

    public void somar()
    {
        Resultado = Valor1 + Valor2;
    }
    public void Subtrair()
    {
        Resultado = Valor1 - Valor2;
    }
    public void Dividir()
    {
        Resultado = Valor1/Valor2;
    }
    public void Multiplicar()
    {
        Resultado = Valor1 * Valor2;
    }
}