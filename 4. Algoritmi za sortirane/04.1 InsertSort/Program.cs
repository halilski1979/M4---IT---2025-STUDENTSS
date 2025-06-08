namespace _04._1_InsertSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = { 2, 5, 3, 7, 4, 6, 1, 0 };
            Console.WriteLine(string.Join(' ', arrayInt));

            InsertSort(arrayInt);
            Console.WriteLine(string.Join(' ', arrayInt));

        }

        public static void InsertSort(int[] masiv)
        {
            for (int i = 1; i < masiv.Length; i++)
            {
                int j = i;
                while (j > 0 && masiv[j - 1] < masiv[j])
                {
                    //Размяна на елементите
                    int temp = masiv[j];
                    masiv[j] = masiv[j-1];
                    masiv[j-1] = temp;

                    j--;
                }
            }
        }
    }
}
