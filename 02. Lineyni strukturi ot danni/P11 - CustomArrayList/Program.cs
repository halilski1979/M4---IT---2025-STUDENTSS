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
                     

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine(arrayList.IndexOf(11)); 

        }
    }
}
