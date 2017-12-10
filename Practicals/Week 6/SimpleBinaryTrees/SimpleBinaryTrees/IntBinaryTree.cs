using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBinaryTrees
{
    public class IntBinaryTree
    {
        public IntBinaryTreeNode RootNode;

        public IntBinaryTree()
        {
            RootNode = null;
        }

        public IntBinaryTree(int rootValue)
        {
            RootNode = new IntBinaryTreeNode(rootValue);
        }

        public IntBinaryTree(int rootValue, IntBinaryTree leftSubtree, IntBinaryTree rightSubtree)
        {
            RootNode = new IntBinaryTreeNode(rootValue);
            IntBinaryTreeNode leftRoot = leftSubtree.RootNode;
            IntBinaryTreeNode rightRoot = rightSubtree.RootNode;
            RootNode.LeftChild = leftRoot;
            RootNode.RightChild = rightRoot;
        }

        public void AddLeftSubtree(IntBinaryTree newLeftSubtree)
        {
            IntBinaryTreeNode leftRootNode = newLeftSubtree.RootNode;
            RootNode.LeftChild = leftRootNode;
        }

        public void AddRightSubtree(IntBinaryTree newRightSubtree)
        {
            IntBinaryTreeNode rightRootNode = newRightSubtree.RootNode;
            RootNode.RightChild = rightRootNode;
        }

        public void MakeLeftChildNode(int dataValue)
        {
            IntBinaryTreeNode newLeftChildNode = new IntBinaryTreeNode(dataValue);
            RootNode.LeftChild = newLeftChildNode;
        }

        public void MakeRightChildNode(int dataValue)
        {
            IntBinaryTreeNode newRightChildNode = new IntBinaryTreeNode(dataValue);
            RootNode.RightChild = newRightChildNode;
        }

        public void PreorderTraversal(IntBinaryTreeNode inputRootNode, ListBox targetListBox)
        {
            if (inputRootNode != null)
            {
                int currentNodeValue = inputRootNode.NodeData;
                targetListBox.Items.Add(currentNodeValue.ToString() + " ");

                IntBinaryTreeNode leftRoot = inputRootNode.LeftChild;
                PreorderTraversal(leftRoot, targetListBox);

                IntBinaryTreeNode rightRoot = inputRootNode.RightChild;
                PreorderTraversal(rightRoot, targetListBox);
            }
        }

        public void InorderTraversal(IntBinaryTreeNode inputRootNode, ListBox targetListBox)
        {
            if (inputRootNode != null)
            {
                IntBinaryTreeNode leftRoot = inputRootNode.LeftChild;
                InorderTraversal(leftRoot, targetListBox);

                int currentNodeValue = inputRootNode.NodeData;
                targetListBox.Items.Add(currentNodeValue.ToString() + " ");

                IntBinaryTreeNode rightRoot = inputRootNode.RightChild;
                InorderTraversal(rightRoot, targetListBox);
            }
        }

        public void PostorderTraversal(IntBinaryTreeNode inputRootNode, ListBox targetListBox)
        {
            if(inputRootNode != null)
            {
                IntBinaryTreeNode leftRoot = inputRootNode.LeftChild;
                PostorderTraversal(leftRoot, targetListBox);

                IntBinaryTreeNode rightRoot = inputRootNode.RightChild;
                PostorderTraversal(rightRoot, targetListBox);

                int currentNodeValue = inputRootNode.NodeData;
                targetListBox.Items.Add(currentNodeValue.ToString() + " ");
            }
        }
    }
}
