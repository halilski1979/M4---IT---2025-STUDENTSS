namespace _04._1_InsertSort___Klas_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 12, 31, 42, 13, 32, 4, 9 };
            Console.WriteLine(string.Join(' ', numbers));

            InsertSortKlas<int> sortInt = new InsertSortKlas<int>();
            sortInt.InsertSort(numbers);
            Console.WriteLine(string.Join(' ', numbers));
            sortInt.InsertSortDes(numbers);
            Console.WriteLine(string.Join(' ', numbers));

            Console.WriteLine();

            string[] fruits = { "banana", "apple", "orange", "kiwi", "cherry" };
            Console.WriteLine(string.Join(' ', fruits));

            InsertSortKlas<string> sortString = new InsertSortKlas<string>();
            sortString.InsertSort(fruits);
            Console.WriteLine(string.Join(' ', fruits));
            sortString.InsertSortDes(fruits);
            Console.WriteLine(string.Join(' ', fruits));
        }
    }
}
