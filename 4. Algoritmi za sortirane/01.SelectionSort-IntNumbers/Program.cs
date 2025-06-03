namespace _01.SelectionSort_IntNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 12, 31, 42, 13, 32, 4, 9 };
            Console.WriteLine(string.Join(' ', numbers));

            SelectionSort(numbers);
            Console.WriteLine(string.Join(' ', numbers));
        }

        public static void SelectionSort(int[] masiv)
        {           

            for (int i = 0; i < masiv.Length; i++)
            {
                int minIndex = i;

                for (int j = i+1; j < masiv.Length; j++)
                {
                    if (masiv[j] < masiv[minIndex])
                    {
                        minIndex = j;
                    }
                }

                //Размяна на текущ елемент с минимален елемент
                int temp=masiv[minIndex];
                masiv[minIndex] = masiv[i];
                masiv[i] = temp;

            }
        }
    }
}
