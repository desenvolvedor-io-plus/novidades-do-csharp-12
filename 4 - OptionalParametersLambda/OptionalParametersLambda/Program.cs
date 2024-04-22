namespace optionalParameters;

internal class Program
{
    static void Main(string[] args)
    {
        var calcularValor = (int numero = 10) => numero * numero;
        Console.WriteLine(calcularValor(5));
        Console.WriteLine(calcularValor());

    }
}