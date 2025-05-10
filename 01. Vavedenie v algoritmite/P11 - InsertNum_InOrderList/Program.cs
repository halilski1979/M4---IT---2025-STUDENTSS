namespace P11___InsertNum_InOrderList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n=int.Parse(Console.ReadLine());
            int index = 0;

            var newNum = new int[num.Length+1];

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i]>n)
                {
                    index = i;
                    break;
                }
            }

            for (int i = 0; i < index; i++)
            {
                newNum[i] = num[i];
            }
            newNum[index] = n;
            for (int i = index; i < num.Length; i++)
            {
                newNum[i+1] = num[i];
            }

            Console.WriteLine(string.Join(" ",num));
            Console.WriteLine(string.Join(" ", newNum));



        }
    }
}
