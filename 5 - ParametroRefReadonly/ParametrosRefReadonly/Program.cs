namespace parametrosRefReadonly;
internal class Program
{
    static void Main(string[] args)
    {
        int outroNumero = 10;

        ExibirValor(ref outroNumero);
        Console.WriteLine(outroNumero);
    }
    static void ExibirValor(ref int numero)
    {
        Console.WriteLine($"valor: {numero}");
        numero++;
    }
}