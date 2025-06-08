namespace _01._LinerSearching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            int index = Search.Linear(arr,3);
            Console.WriteLine(index);

            Search searchIndex=new Search();
            Console.WriteLine(searchIndex.LinearSearch(arr, 1));

            Console.WriteLine(searchIndex.LinearSearchElemennt(arr, 5)); 
        }
    }
}
