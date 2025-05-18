namespace P03___Stack___STEK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Li Fo - Last In, First Out => последен влязъл, първи излиза
            Stack<int> stack = new Stack<int>();

            //Push – добавя елемент най-горе в стека
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }

            //Pop – премахва най-горния елемент в стека
            Console.WriteLine();
            Console.WriteLine(stack.Pop());
            Console.WriteLine();
            Console.WriteLine(stack.Pop());

            // Peek – връща най-горния елемент в стека, без да го премахва
            Console.WriteLine();
            Console.WriteLine(stack.Peek());

            Console.WriteLine();
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }

            //ToArray() – преобразува стека в обикновен масив
            int[]number= stack.ToArray();
            List<int> spisak=stack.ToList();

            spisak.Add(111);
            foreach (int i in spisak)
            {
                Console.WriteLine(i);
            }

            //Clear
            stack.Clear();
            Console.WriteLine(stack.Pop());


        }
    }
}
