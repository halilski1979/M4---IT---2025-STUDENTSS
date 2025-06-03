namespace _11._Faktoriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FactorielRekursia(0));
        }

        public static int Factoriel(int n)
        {
            int p = 1;
            for (int i = 1; i <= n; i++)
            {
                p=p*i;
            }
            return p;
        }

        public static int FactorielRekursia(int n)
        {
            if (n == 0 || n==1)
            {
                return 1;
            }

            return n * FactorielRekursia(n - 1);
        }
    }
}
