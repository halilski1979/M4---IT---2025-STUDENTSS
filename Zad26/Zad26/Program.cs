namespace Zad26
{
    internal class Program
    {
        //12-01-2002
        static void Main(string[] args)
        {
           List<int> listOfSum = new List<int>();
           int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string data = Console.ReadLine();
                int temp=SumDigit(data);
                listOfSum.Add(temp);
            }
            //Obhod na spisaka ot sumi
            for (int i = 0; i < listOfSum.Count; i++)
            {
                int number = listOfSum[i];
                while (number>9&&number!=11&&number!=22)
                {
                    int sum = 0;
                    while (number>0)
                    {
                        int digit = number % 10;
                        sum += digit;
                        number/=10;
                    }
                    number = sum;
                }
                listOfSum[i] = number;
            }
            //test
            Dictionary<int,int> map = new Dictionary<int,int>();
            foreach (int item in listOfSum) 
            {
                if (map.ContainsKey(item))
                {
                    map[item]++;
                }
                else
                {
                    map[item] = 1;
                }
            }
            var bestNumber=map.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key).FirstOrDefault();
            Console.WriteLine($"The most common personal number is {bestNumber.Key} - {bestNumber.Value} times");
        }
        static int SumDigit(string data)
        {
            string[] input = data.Split('-');
            int sumDays = input[0].Sum(x => int.Parse(x.ToString()));
            int sumMes = input[1].Sum(x => int.Parse(x.ToString()));
            int sumYear = input[2].Sum(x => int.Parse(x.ToString()));
            int totalSum = sumDays + sumMes + sumYear;
            return totalSum;
        }
    }
}
