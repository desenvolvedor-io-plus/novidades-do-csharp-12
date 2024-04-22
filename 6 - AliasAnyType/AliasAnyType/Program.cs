namespace aliasAnyType;
using Meusponteiro = (int X, int Y);
internal class Program
{
    static void Main(string[] args)
    {
        Meusponteiro ponteiros = (X: 10, Y: 20);
        Console.WriteLine($"{ponteiros.X} {ponteiros.Y}");
    }
}