namespace _00._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 12, 31, 42, 13, 32, 4, 9 };
            Console.WriteLine(string.Join(' ',numbers));

            numbers=numbers.OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
