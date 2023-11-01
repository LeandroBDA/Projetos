namespace Concessionária;

public class Veiculo
{
    public Veiculo (string autoMovel, string marca, string modelo, int ano, string preço)
    {
        AutoMovel = autoMovel;
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Preço = preço;
    }
    public string AutoMovel { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public string Preço { get; set; }
}