namespace Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int n=Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvenAndOdds(n));
        }
        static double GetSumOfEvenDigits(int number)
        {
            double sumEvent = 0;
            while (number > 0) 
            { 
                int digit = number % 10;
                if (digit%2==0)
                {
                    sumEvent += digit;
                }
                number /= 10;
            }
            return sumEvent;
        }//end1
        static double GetSumOfOddDigits(int number)
        {
            double sumOdd = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    sumOdd += digit;
                }
                number /= 10;
            }
            return sumOdd;
        }//end2
        static double GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfEvenDigits(number) *GetSumOfOddDigits(number);
        }//end3
    }
}
