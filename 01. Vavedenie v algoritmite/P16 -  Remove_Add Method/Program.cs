namespace P16____Remove_Add_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
           
            int number=int.Parse(Console.ReadLine());

            if (num.Contains(number))
            {
                num.Remove(number);
            }
            else
            {
                num.Add(number);
            }

            num.Sort();

            Console.WriteLine(string.Join(" ",num));
        }
    }
}
