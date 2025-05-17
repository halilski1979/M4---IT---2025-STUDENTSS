namespace P10___ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ArrayList<int> num = new ArrayList<int>();

            num.Add(1);
            num.Add(2);
            num.Add(3);

            Console.WriteLine(num.Capacity);
            Console.WriteLine(num.Count);

            num.Add(11);
            num.Add(22);
            num.Add(33);

            Console.WriteLine();
            Console.WriteLine(num.Capacity);
            Console.WriteLine(num.Count);

            Console.WriteLine();
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine(num[0]);

            
        }
    }
}
