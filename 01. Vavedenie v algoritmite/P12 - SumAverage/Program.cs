namespace P12___SumAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int s = 0;
            double average = 0;

            for (int i = 0; i < num.Count; i++)
            {
                s += num[i];
            }
            average =(double)s/(double)num.Count;
            Console.WriteLine(s);
            Console.WriteLine($"{average:f2}");

        }
    }
}
