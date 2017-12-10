using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBinaryTrees
{
    public class StringBinaryTreeNode
    {
        public String NodeData { get; set; }
        public StringBinaryTreeNode LeftChild { get; set; }
        public StringBinaryTreeNode RightChild { get; set; }

        public StringBinaryTreeNode(String dataValue)
        {
            NodeData = dataValue;
            LeftChild = null;
            RightChild = null;
        }
    }
}
