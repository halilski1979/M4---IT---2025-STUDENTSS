namespace _02._SlectionSort___typeT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 12, 31, 42, 13, 32, 4, 9 };
            Console.WriteLine(string.Join(' ', numbers));
            SelectionSort(numbers);
            Console.WriteLine(string.Join(' ', numbers));
            Console.WriteLine();

            string[] fruits = { "banana", "apple", "orange", "kiwi", "cherry" };
            Console.WriteLine(string.Join(' ', fruits));
            SelectionSort(fruits);
            Console.WriteLine(string.Join(' ', fruits));
            Console.WriteLine();


            char[] chars = { 'b', 'a', 'c','m','k' };
            Console.WriteLine(string.Join(' ', chars));
            SelectionSort(chars);
            Console.WriteLine(string.Join(' ', chars));
            Console.WriteLine();
        }

        public static void SelectionSort<T>(T[] masiv) where T : IComparable<T> 
        {
            for (int i = 0; i < masiv.Length; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < masiv.Length; j++)
                {
                    if (masiv[j].CompareTo(masiv[minIndex])<0)
                    {
                        minIndex= j;
                    }
                }

                //Размяна на текущ с минимален
                if (minIndex!=0)
                {
                    T temp = masiv[i];
                    masiv[i]= masiv[minIndex];
                    masiv[minIndex]= temp;
                }
            }
        }
    }
}
