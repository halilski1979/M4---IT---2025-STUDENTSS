namespace P13___ReversedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RveresedList<int> ints = new RveresedList<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }
    }
}
