namespace P11___Insert_In_OrderedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int number=int.Parse(Console.ReadLine());
            num=num.OrderBy(x => x).ToList();
            
            int index = 0;

            var newNum=new List<int>();

            for (int i = 0; i < num.Count; i++)
            {
                if (num[i]>number)
                {
                    index = i; break;
                }
            }

            Console.WriteLine($"Index: {index}");

            for (int i = 0; i < index; i++)
            {
                newNum.Add(num[i]);
            }

            newNum.Add(number);

            for (int i = index; i < num.Count; i++)
            {
                newNum.Add(num[i]);
            }

            Console.WriteLine(string.Join(" ",num));
            Console.WriteLine(string.Join(" ", newNum));
        }
    }
}
