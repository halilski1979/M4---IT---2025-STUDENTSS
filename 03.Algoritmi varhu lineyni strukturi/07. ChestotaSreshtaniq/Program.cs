namespace _07._ChestotaSreshtaniq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var counter=new Dictionary<int, int>();
            foreach(int item in list)
            {
                if (counter.ContainsKey(item))
                {
                    counter[item]++;
                }
                else
                {
                    counter.Add(item, 1);
                }
            }

            foreach (var item in counter)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

            Console.WriteLine($"Counter: {counter.Count}");
        }
    }
}
