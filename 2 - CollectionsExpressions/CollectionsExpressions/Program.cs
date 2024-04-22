namespace CollectionExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Lista = [100, 200, 300, 400];
            List<int> Lista2 = [];

            foreach (int i in Lista2)
            {
                Console.WriteLine(i);
            }
        }
    }
}