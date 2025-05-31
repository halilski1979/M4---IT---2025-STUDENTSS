namespace _06.DeleteNegativeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result=new List<int>();

            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] > 0)
                    result.Add(number[i]);
            }

            Console.WriteLine(string.Join(' ',result));

        }
    }
}
