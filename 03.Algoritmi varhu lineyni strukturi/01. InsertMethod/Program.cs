namespace _01._InsertMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]num=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number=int.Parse(Console.ReadLine());

            num=num.OrderBy(x => x).ToArray();
            int index = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > number)
                {
                    index = i;
                    break;
                }
                    
            }
            
            int [] newNum=new int [num.Length+1];

            for (int i = 0; i < index; i++)
            {
                newNum[i] = num[i];
            }
            newNum[index] = number;

            for (int i = index; i < num.Length; i++)
            {
                newNum[i+1] = num[i];
            }


            Console.WriteLine(string.Join(' ',num));
            Console.WriteLine(string.Join(' ', newNum));

        }
    }
}
