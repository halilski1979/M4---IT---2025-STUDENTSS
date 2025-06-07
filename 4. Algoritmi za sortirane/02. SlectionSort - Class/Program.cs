namespace _02._SlectionSort___Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]arrayInt = { 2, 5, 3,7,4,6,1,0 };
            Console.WriteLine(string.Join(' ',arrayInt));
            
            SelectionSort<int> selectionSort = new SelectionSort<int>();
            selectionSort.SortAscending(arrayInt);
            Console.WriteLine(string.Join(' ', arrayInt));
            selectionSort.SortDescending(arrayInt);
            Console.WriteLine(string.Join(' ', arrayInt));

            Console.WriteLine();
            string[] fruits = { "banana", "apple", "orange", "kiwi", "cherry" };

            Console.WriteLine(string.Join(' ', fruits));
            SelectionSort<string> selectionSortString = new SelectionSort<string>();
            selectionSortString.SortAscending(fruits);
            Console.WriteLine(string.Join(' ', fruits));
            selectionSortString.SortDescending(fruits);
            Console.WriteLine(string.Join(' ', fruits));


        }
    }
}
