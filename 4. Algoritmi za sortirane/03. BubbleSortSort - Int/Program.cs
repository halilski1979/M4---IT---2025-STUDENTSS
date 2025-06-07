namespace _03._BubbleSortSort___Int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = { 2, 5, 3, 7, 4, 6, 1, 0 };
            Console.WriteLine(string.Join(' ', arrayInt));

            Sort(arrayInt);
            Console.WriteLine(string.Join(' ', arrayInt));
            Console.WriteLine();

            SortDescending(arrayInt);
            Console.WriteLine(string.Join(' ', arrayInt));
        }

        public static void Sort(int[]masiv)
        {
            for (int i = 0; i < masiv.Length-1; i++)
            {
                for (int j = 0; j < masiv.Length-1-i; j++)
                {
                    if (masiv[j] > masiv[j+1])
                    {
                        int temp = masiv[j];
                        masiv[j]=masiv[j+1];
                        masiv[j + 1] = temp;
                    }
                }
            }
        }

        public static void SortDescending(int[] masiv)
        {
            for (int i = 0; i < masiv.Length - 1; i++)
            {
                for (int j = 0; j < masiv.Length - 1 - i; j++)
                {
                    if (masiv[j] < masiv[j + 1])
                    {
                        int temp = masiv[j];
                        masiv[j] = masiv[j + 1];
                        masiv[j + 1] = temp;
                    }
                }
            }
        }
    }
}
