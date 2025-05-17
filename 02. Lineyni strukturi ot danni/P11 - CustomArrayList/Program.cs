using System.ComponentModel;

namespace P11___CustomArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CustomArrayList arrayList = new CustomArrayList();
            Console.WriteLine($"Capacity: {arrayList.Capacity}");
            Console.WriteLine($"Count: {arrayList.Count}");

            arrayList.Add(10);
            arrayList.Add("Name");
            arrayList.Add('!');
            arrayList.Add(true);

            Console.WriteLine(arrayList.Get(1));

            Console.WriteLine();
            arrayList.Insert(1, "Mercedes");
            Console.WriteLine(arrayList.Get(1));

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
