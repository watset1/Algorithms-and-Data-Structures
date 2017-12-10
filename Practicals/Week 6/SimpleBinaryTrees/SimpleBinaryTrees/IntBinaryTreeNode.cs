using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBinaryTrees
{
    public class IntBinaryTreeNode
    {
        public int NodeData { get; set; }
        public IntBinaryTreeNode LeftChild;
        public IntBinaryTreeNode RightChild;

        public IntBinaryTreeNode(int dataValue)
        {
            NodeData = dataValue;
            LeftChild = null;
            RightChild = null;
        }
    }
}
