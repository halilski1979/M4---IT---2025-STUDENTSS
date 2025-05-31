namespace _02._MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]num=Console.ReadLine().Split().Select(int.Parse).ToArray();           
            int min = num[0];           
           

            for (int i = 1; i < num.Length; i++)
            {
                if (min > num[i])
                {
                    min = num[i];
                }
            }

            Console.WriteLine(min);
        }
    }
}
