namespace _09._Direktorii___BFS
{
    internal class Program
    {
       private static Queue<string> folders=new Queue<string>();
       
       private static void ProcessFolder(string path)
        {
            string[]dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {
                folders.Enqueue(dir);
            }
        }


        static void Main(string[] args)
        {
            ProcessFolder(@"C:\");
            while (folders.Count>0)
            {
                try
                {
                    var folder = folders.Dequeue();
                    Console.WriteLine(folder);
                    ProcessFolder(folder);
                }
                catch (Exception)
                {

                    throw new Exception("Error");
                }
            }
        }
    }
}
