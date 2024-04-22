namespace PrimaryConstructors;

internal class Program
{
    static void Main(string[] args)
    {
        var pessoa = new Pessoa("","");
        Console.WriteLine(pessoa.nomeCompleto());
    }
}
