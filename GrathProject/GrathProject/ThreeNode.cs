using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrathProject
{
    public class ThreeNode
    {
        public int Value { get; set; }
        public ThreeNode Parent { get; set; }
        public List<ThreeNode> Children { get; set; }
        public ThreeNode(int value)
        { 
            this.Value = value;
            this.Children = new List<ThreeNode>();
        }
        public void AddChild(ThreeNode child) 
        { 
            Children.Add(child);
            child.Parent = this;
        }
    }
}
