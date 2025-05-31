using System.Windows.Markup;

namespace _04._SlivaneSpisaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var first=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var second = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            first.AddRange(second);
            first=first.OrderByDescending(x => x).ToList();
            Console.WriteLine(string.Join(' ',first));


        }
    }
}
