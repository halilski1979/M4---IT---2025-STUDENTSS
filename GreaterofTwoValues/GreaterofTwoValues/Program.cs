namespace GreaterofTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int first=int.Parse(Console.ReadLine());
                int second=int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first,second));
            }
            else if (type=="char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first,second));
            }
            else if (type=="string")
            {
                string? first = Console.ReadLine();
                string? second = Console.ReadLine();
                Console.WriteLine(GetMax(first,second));
            }
        }
        static int GetMax(int first,int second)
        {
            if (first > second) 
            {
                return first;
            }
            return second;
        }//end1
        static char GetMax(char first, char second)
        {
            if (first>second)
            {
                return first;
            }
            return second;
        }//end2
        static string GetMax(string first, string second) 
        {
            if (first.CompareTo(second)==1)
            {
                return first;
            }
            return second;
        }//end3
    }
}
