namespace _04._1_InsertSort___T_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 12, 31, 42, 13, 32, 4, 9 };
            Console.WriteLine(string.Join(' ', numbers));
            InsertSort(numbers);
            Console.WriteLine(string.Join(' ', numbers));

            string[] fruits = { "banana", "apple", "orange", "kiwi", "cherry" };
            Console.WriteLine(string.Join(' ', fruits));
            InsertSort(fruits);
            Console.WriteLine(string.Join(' ', fruits));
            Console.WriteLine();
        }


        public static void InsertSort<T>(T[]masiv) where T : IComparable<T> 

        {
            for (int i = 0; i < masiv.Length; i++)
            {
                int j = i;
                while (j > 0 && masiv[j - 1].CompareTo(masiv[j]) > 0)
                {
                    //Размяна на елементи
                    T temp=masiv[j-1];
                    masiv[j-1]=masiv[j];
                    masiv[j]=temp;

                    j--;
                }
            }
        }
    }
}
