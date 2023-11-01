using CalculadoraSimplesAPI.Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraSimplesAPI.Controllers;

[ApiController]
[Route("api/controller")]
public class CalculadoraController : Controller
{
    [HttpGet("Somar{valor1}/{valor2}")]

    public ActionResult<Calculadora> Somar(double valor1, double valor2)
    {
        var calc = new Calculadora(valor1, valor2);
        calc.somar();
        return Ok(calc);
    }
    [HttpGet("Subtrair{valor1}/{valor2}")]

    public ActionResult Subtrair(double valor1, double valor2)
    {
        var calc = new Calculadora(valor1, valor2);
        calc.Subtrair();
        return Ok(calc);
    }
    
    [HttpGet("Dividir{valor1}/{valor2}")]

    public ActionResult Dividir(double valor1, double valor2)
    {
        var calc = new Calculadora(valor1, valor2);
        calc.Dividir();
        return Ok(calc);
    }
    [HttpGet("Multiplicar{valor1}/{valor2}")]

    public ActionResult Multiplicar(double valor1, double valor2)
    {
        var calc = new Calculadora(valor1, valor2);
        calc.Multiplicar();
        return Ok(calc);
    }
}