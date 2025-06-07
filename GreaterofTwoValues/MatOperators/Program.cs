namespace MatOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double first=double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double second=double.Parse(Console.ReadLine());
            Console.WriteLine(MathOperators(first,type,second));
            
        }
        static double MathOperators(double a,string @operator ,double b) 
        {
            double resultOperations = 0;
            switch (@operator)
            {
                case "+":
                    resultOperations = a + b;
                    break;
                    case "-":
                    resultOperations = a - b;
                    break;
                    case "*":
                    resultOperations = a * b;
                    break;
                    case "/":
                    resultOperations = a / b;
                    break;
            }
            return resultOperations;
        }//end1
    }
}
