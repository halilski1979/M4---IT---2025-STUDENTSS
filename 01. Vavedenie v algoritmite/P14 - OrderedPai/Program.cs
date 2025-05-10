namespace P14___OrderedPai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n=int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (int k = 0; k <=p; k++)
                    {
                        Console.WriteLine($"{i} {j} {k}");
                        counter++;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Counter: {counter}");
        }
    }
}
