namespace P11___InsertNumberMasiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var number=int.Parse(Console.ReadLine());

            int index = 0;
            var newNum = new int[num.Length + 1];

            //Намиране на позиция за вмъкване на новия елемент
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i]>number)
                {
                    index = i;
                    break;
                }
            }

            //Koпираме първата част от масива в новия масив
            for (int i = 0; i < index; i++)
            {
                newNum[i] = num[i];
            }

            newNum[index] = number;

            //Копираме останалата част на масива в новия масив
            for (int i = index; i < num.Length; i++)
            {
                newNum[i+1]=num[i];
            }

            Console.WriteLine(string.Join(" ",num));
            Console.WriteLine(string.Join(" ", newNum));
        }
    }
}
