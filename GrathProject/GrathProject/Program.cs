namespace GrathProject
{
    internal class Program
    {
        static Dictionary<int,ThreeNode>nodeByValue = new Dictionary<int,ThreeNode>();
        static ThreeNode GetOrCreateNode(int value)
        {
            if (!nodeByValue.ContainsKey(value))
            {
                nodeByValue[value] = new ThreeNode(value);
            }
            return nodeByValue[value];
        }//end1
        static ThreeNode FindRoot()
        {
            foreach (ThreeNode node in nodeByValue.Values)
            {
                if (node.Parent==null)
                {
                    return node;
                }
            }
            return null;
        }//end 2
        static void Main(string[] args)
        {
            Console.Write("Въведете брой възли: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n-1; i++)
            {
                string[] parts = Console.ReadLine().Split(' ');
                int parentValue=int.Parse(parts[0]);
                int childValue=int.Parse(parts[1]);
                ThreeNode parentNode=GetOrCreateNode(parentValue);
                ThreeNode childParent=GetOrCreateNode(childValue);
                parentNode.AddChild(childParent);
            }
            //Търсим корена на дървото
            ThreeNode root= FindRoot();
            Console.WriteLine($"Коренът на дървото е: {root.Value}");
        }
    }
}
