namespace P02___Queue___OPASHKA
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Опашка от типа FI FO - First In, First Out
           Queue<int> opashka = new Queue<int>();
           
            //Enqueue() - добавя елемент
            opashka.Enqueue(1);
            opashka.Enqueue(2);
            opashka.Enqueue(3);
            opashka.Enqueue(4);
            opashka.Enqueue(5);

            foreach (int i in opashka)
            {
                Console.WriteLine(i);
            }

            //Dequeue() – премахва и връща елемента от началото
            Console.WriteLine();
            Console.WriteLine(opashka.Dequeue());

            Console.WriteLine();
            Console.WriteLine(opashka.Dequeue());

            Console.WriteLine();
            foreach (int i in opashka)
            {
                Console.WriteLine(i);
            }

            //Peek() – връща елемента от началото без триене
            Console.WriteLine();
            Console.WriteLine(opashka.Peek());

            Console.WriteLine($"Count: {opashka.Count}");


            //ToArray() – преобразува опашка в обикновен масив
            int[]number=opashka.ToArray();
            List<int> spisak=opashka.ToList();
            spisak.Add(111);
            Console.WriteLine("Spisak:");
            foreach (int i in spisak)
            {
                Console.WriteLine(i);
            }
        }
    }
}
