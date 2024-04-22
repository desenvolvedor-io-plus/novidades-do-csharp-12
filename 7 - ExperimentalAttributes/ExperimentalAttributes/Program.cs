using System.Diagnostics.CodeAnalysis;

namespace experimentalAttribute;

public class Program
{
    static void Main(string[] args)
    {

#pragma warning disable Teste // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
        var resultado = ObterNumero();
#pragma warning restore Teste // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

        Console.WriteLine($"numero: {resultado}");

    }
    [Experimental("Teste")]
    static int ObterNumero()
    {
        return 2;
    }
}