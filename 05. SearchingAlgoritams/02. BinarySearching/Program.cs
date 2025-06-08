namespace _02._BinarySearching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search:");

            int[] array = { 1, 2, 3, 4, 5 };

            int index = Search.Binary<int>(array, 2);
            if (index > 0)
            {
                Console.WriteLine("Element [2] found at index [{0}].", index);
            }
            else
            {
                Console.WriteLine("Element [2] not found.");
            }
        }
    }
}
