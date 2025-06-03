namespace _10._Rekursia___SumArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            int s = Sum(numbers,3);
            Console.WriteLine(s);
        }

        public static int Sum(int[] masiv,int index)
        {
            if (index == masiv.Length - 1)
            {
                return masiv[index];
            }
            return masiv[index]+Sum(masiv, index+1);
        }


    }
}
