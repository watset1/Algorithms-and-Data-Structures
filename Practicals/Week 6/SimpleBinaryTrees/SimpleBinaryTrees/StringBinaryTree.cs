using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBinaryTrees
{
    public class StringBinaryTree
    {
        public StringBinaryTreeNode RootNode { get; set; }

        public StringBinaryTree()
        {
            RootNode = null;
        }

        public StringBinaryTree(String rootValue)
        {
            RootNode = new StringBinaryTreeNode(rootValue);
        }

        public StringBinaryTree(String rootValue, StringBinaryTree leftSubtree, StringBinaryTree rightSubtree)
        {
            RootNode = new StringBinaryTreeNode(rootValue);
            StringBinaryTreeNode leftRoot = leftSubtree.RootNode;
            StringBinaryTreeNode rightRoot = rightSubtree.RootNode;
            RootNode.LeftChild = leftRoot;
            RootNode.RightChild = rightRoot;
        }

        public void AddLeftSubtree(StringBinaryTree newLeftSubtree)
        {
            StringBinaryTreeNode leftRootNode = newLeftSubtree.RootNode;
            RootNode.LeftChild = leftRootNode;
        }

        public void AddRightSubtree(StringBinaryTree newRightSubtree)
        {
            StringBinaryTreeNode rightRootNode = newRightSubtree.RootNode;
            RootNode.RightChild = rightRootNode;
        }

        public void MakeLeftChildNode(String dataValue)
        {
            StringBinaryTreeNode newLeftChildNode = new StringBinaryTreeNode(dataValue);
            RootNode.LeftChild = newLeftChildNode;
        }

        public void MakeRightChildNode(String dataValue)
        {
            StringBinaryTreeNode newRightChildNode = new StringBinaryTreeNode(dataValue);
            RootNode.RightChild = newRightChildNode;
        }

        public void PreorderTraversal(StringBinaryTreeNode inputRootNode, ListBox targetListBox)
        {
            if (inputRootNode != null)
            {
                String currentNodeValue = inputRootNode.NodeData;
                targetListBox.Items.Add(currentNodeValue.ToString() + " ");

                StringBinaryTreeNode leftRoot = inputRootNode.LeftChild;
                PreorderTraversal(leftRoot, targetListBox);

                StringBinaryTreeNode rightRoot = inputRootNode.RightChild;
                PreorderTraversal(rightRoot, targetListBox);
            }
        }

        public void InorderTraversal(StringBinaryTreeNode inputRootNode, ListBox targetListBox)
        {
            if (inputRootNode != null)
            {
                StringBinaryTreeNode leftRoot = inputRootNode.LeftChild;
                InorderTraversal(leftRoot, targetListBox);

                String currentNodeValue = inputRootNode.NodeData;
                targetListBox.Items.Add(currentNodeValue.ToString() + " ");

                StringBinaryTreeNode rightRoot = inputRootNode.RightChild;
                InorderTraversal(rightRoot, targetListBox);
            }
        }

        public void PostorderTraversal(StringBinaryTreeNode inputRootNode, ListBox targetListBox)
        {
            if(inputRootNode != null)
            {
                StringBinaryTreeNode leftRoot = inputRootNode.LeftChild;
                PostorderTraversal(leftRoot, targetListBox);

                StringBinaryTreeNode rightRoot = inputRootNode.RightChild;
                PostorderTraversal(rightRoot, targetListBox);

                String currentNodeValue = inputRootNode.NodeData;
                targetListBox.Items.Add(currentNodeValue.ToString() + " ");
            }
        }
    }
}
