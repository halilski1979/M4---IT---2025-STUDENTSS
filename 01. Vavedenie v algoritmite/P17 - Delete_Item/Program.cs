using System.Threading.Tasks.Dataflow;

namespace P17___Delete_Item
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var newNum = new int[num.Length-1];

            int number=int.Parse(Console.ReadLine());
            int index = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (number == num[i])
                {
                    index=i; 
                    break;
                }
            }
            Console.WriteLine($"Index: {index}");

            for (int i = 0; i < index; i++)
            {
                newNum[i] = num[i];
            }

            for (int i = index; i < newNum.Length; i++)
            {
                newNum[i]=num[i+1];
            }

            Console.WriteLine(string.Join(" ",newNum));
        }
    }
}
