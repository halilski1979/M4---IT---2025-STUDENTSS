namespace P10___NumberInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int number=int.Parse(Console.ReadLine());

            if (num.Contains(number))       
                Console.WriteLine("Exist");            
            else    
                 Console.WriteLine("Not exist");
          
        }
    }
}
