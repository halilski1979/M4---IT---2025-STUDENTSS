namespace _08._MajorantMasiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var counter=new Dictionary<int, int>();

            foreach (var item in numbers)
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

            var mostNumber=counter.OrderByDescending(x => x.Value).FirstOrDefault();
            if (counter.Count/2+1<mostNumber.Value)
            {
                Console.WriteLine(mostNumber.Key);
            }
            else
            {
                Console.WriteLine("The majorant does not exists!");
            }

        }
    }
}
