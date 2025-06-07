namespace _03._1_BubbleSortSort___T_ype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 12, 31, 42, 13, 32, 4, 9 };
            Console.WriteLine(string.Join(' ', numbers));
            Sort(numbers);
            Console.WriteLine(string.Join(' ', numbers));

            string[] fruits = { "banana", "apple", "orange", "kiwi", "cherry" };
            Console.WriteLine(string.Join(' ', fruits));
            SortDescending(fruits);
            Console.WriteLine(string.Join(' ', fruits));
            Console.WriteLine();
        }

        public static void Sort<T>(T[] masiv) where T : IComparable<T>
        {
            for (int i = 0; i < masiv.Length-1; i++)
            {
                for (int j = 0; j < masiv.Length-1-i; j++)
                {
                    if (masiv[j].CompareTo(masiv[j+1])>0)
                    {
                        T temp = masiv[j];
                        masiv[j]=masiv[j+1];
                        masiv[j+1]=temp;
                    }
                }
            }
        }

        public static void SortDescending<T>(T[] masiv) where T : IComparable<T>
        {
            for (int i = 0; i < masiv.Length - 1; i++)
            {
                for (int j = 0; j < masiv.Length - 1 - i; j++)
                {
                    if (masiv[j].CompareTo(masiv[j + 1]) > 0)
                    {
                        T temp = masiv[j];
                        masiv[j] = masiv[j + 1];
                        masiv[j + 1] = temp;
                    }
                }
            }
        }
    }
}
