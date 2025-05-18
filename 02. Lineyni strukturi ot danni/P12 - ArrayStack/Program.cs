namespace P12___ArrayStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayStack<string> stack = new ArrayStack<string>();
            stack.Push("Ivan");
            stack.Push("Petar");
            stack.Push("Hristo");
            Console.WriteLine(stack.Count);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
           
            stack.Pop();

            Console.WriteLine();
            string []name =stack.ConvertToMasiv();
            Console.WriteLine(name[1]);

            Console.WriteLine(stack.Count);
        }
    }
}
