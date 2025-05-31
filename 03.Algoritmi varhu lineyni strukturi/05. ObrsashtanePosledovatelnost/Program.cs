namespace _05._ObrsashtanePosledovatelnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                stack.Push(number);
            }

            foreach (var item in stack)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
