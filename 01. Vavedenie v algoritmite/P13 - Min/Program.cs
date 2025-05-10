namespace P13___Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num=Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int min=int.MaxValue;

            for (int i = 0; i < num.Count; i++)
            {
                if (num[i]<min)
                {
                    min = num[i];
                }
            }

            Console.WriteLine(min);
        }
    }
}
