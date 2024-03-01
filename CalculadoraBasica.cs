
namespace Calculadora;

public class CalculadoraBasica : ICalculadora
{
    
    public void CheckKey()
    {
        Console.WriteLine("Aperte 'F' para fechar o processo e 'C' para continuar ");
        var option = Console.ReadKey();
        Console.Clear();
        if (option.Key == ConsoleKey.F)
        {
            Environment.Exit(0);
        }else if (option.Key == ConsoleKey.C)
        {
            Operacao();
        }
        
    }
    public void Operacao()
    {
        
        Console.WriteLine("Coloque um numero: ");
        float numberX = float.Parse(Console.ReadLine() ?? string.Empty);
        
        
        Console.WriteLine("Lista de operadores: Subtração '-', Adição '+', Multiplicação '*', divisão '/' ");
        Console.WriteLine("Coloque o operador: ");
        char operadores = char.Parse(Console.ReadLine() ?? string.Empty);

        Console.WriteLine("Digite outro numero: ");
        float numberY = float.Parse(Console.ReadLine() ?? string.Empty);
        
        
        float valor;
        switch (operadores)
        {
            case '-':
                valor = numberX - numberY;
                Console.WriteLine("Resultado: "+valor);
                break;
            case '+':
                valor = numberX + numberY;
                Console.WriteLine("Resultado: "+valor);
                break;

            case '/':
                valor = numberX / numberY;
                Console.WriteLine("Resultado: "+valor);
                break;

            case '*':
                valor = numberX * numberY;
                Console.WriteLine("Resultado: "+valor);
                break;
        }

        Environment.Exit(0);
    }

}