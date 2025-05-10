namespace P01___SborCifriChislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SborCifri();
        }

        private static void SborCifri()
        {
            int n = int.Parse(Console.ReadLine());
            int s = 0;

            while (n > 0)
            {
                s += n % 10;
                n /= 10;
            }
            Console.WriteLine(s);
        }
    }
}
