namespace _03._2_BubbleSortSort___Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = { 2, 5, 3, 7, 4, 6, 1, 0 };
            Console.WriteLine(string.Join(' ', arrayInt));

            BubbleSortKlas<int> sortInt = new BubbleSortKlas<int>();
            sortInt.Sort(arrayInt);
            Console.WriteLine(string.Join(' ', arrayInt));
            Console.WriteLine();



            string[] fruits = { "banana", "apple", "orange", "kiwi", "cherry" };
            Console.WriteLine(string.Join(' ', fruits));
            BubbleSortKlas<string> sortString = new BubbleSortKlas<string>();
            sortString.Sort(fruits);
            Console.WriteLine(string.Join(' ', fruits));
            Console.WriteLine();


            char[] chars = { 'b', 'a', 'c', 'm', 'k' };
            Console.WriteLine(string.Join(' ', chars));
            BubbleSortKlas<char> sortChar = new BubbleSortKlas<char>();
            sortChar.Sort(chars);
            Console.WriteLine(string.Join(' ', chars));
        }
    }
}
