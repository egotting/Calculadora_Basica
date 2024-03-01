namespace Calculadora;

public class Progam
{
    static void Main()
    {
        Console.Clear();
        CalculadoraBasica calculadoraBasica= new CalculadoraBasica();
        
        calculadoraBasica.CheckKey();
        calculadoraBasica.Operacao();
    }
}