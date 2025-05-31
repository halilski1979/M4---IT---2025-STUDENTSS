namespace _04._PodrejdaneDumi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words=Console.ReadLine().Split(' ').ToList();

            var result=new List<string>();

            //var minimum = words[0];
            var minimum=words.First();

            for (int m = 0; m < words.Count; m++)
            {
                for (int i = 0; i < words.Count; i++)
                {
                    if (words[i].CompareTo(minimum) < 0)
                    {
                        minimum = words[i];
                    }
                }
                result.Add(minimum);
                words.Remove(minimum);
                minimum = words.First();
            }
            result.Add(words.First());

            Console.WriteLine(string.Join(' ',result));

        }
    }
}
