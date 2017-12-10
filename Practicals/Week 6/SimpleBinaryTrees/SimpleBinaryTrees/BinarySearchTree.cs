using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBinaryTrees
{
    public class BinarySearchTree : IntBinaryTree
    {
        public int InspectionCount { get; set; } //Count to get amount of comparisons per search

        public BinarySearchTree()
        {
            RootNode = null;
        }

        public BinarySearchTree(int rootValue)
        {
            RootNode = new IntBinaryTreeNode(rootValue);
        }

        public BinarySearchTree(int rootValue, IntBinaryTree leftSubtree, IntBinaryTree rightSubtree)
        {
            RootNode = new IntBinaryTreeNode(rootValue);
            IntBinaryTreeNode leftRoot = leftSubtree.RootNode;
            IntBinaryTreeNode rightRoot = rightSubtree.RootNode;
            RootNode.LeftChild = leftRoot;
            RootNode.RightChild = rightRoot;
        }

        //Recursive call to add a value to a binary tree
        public void InsertItem(ref IntBinaryTreeNode treeRoot, int insertValue) //Reference to treeRoot node passed in
        {
            if (treeRoot == null) //Base case
            {
                //Adds a new node, passing in a value to the new node, if the treeRoot is a leaf child pointer
                IntBinaryTreeNode newNode = new IntBinaryTreeNode(insertValue);
                treeRoot = newNode;
            }
            else 
            {
                //Otherwise calls itself recursively passing in a child node depending on the size of the value compared to the current node
                if (insertValue < treeRoot.NodeData)
                    InsertItem(ref treeRoot.LeftChild, insertValue);
                else
                    InsertItem(ref treeRoot.RightChild, insertValue);
            }
        }

        //Wrapper to add value/node
        public void AddNode(int nodeValue)
        {
            InsertItem(ref RootNode, nodeValue);
        }

        //Recursive search function to compare target value with current node
        public bool FindItem(IntBinaryTreeNode inputRootNode, int targetValue)
        {
            InspectionCount++; //For comparison analysis
            if (inputRootNode == null) //Base case
                return false;
            else
                //If search value is the same as the current node data value returns true otherwise checks the left or right child dependant on the size of the target value
                if (inputRootNode.NodeData.Equals(targetValue)) 
                    return true;
                else
                    if (targetValue < inputRootNode.NodeData)
                        return FindItem(inputRootNode.LeftChild, targetValue);
                    else
                        return FindItem(inputRootNode.RightChild, targetValue);
        }

        //Search wrapper
        public bool Search(int targetValue)
        {
            InspectionCount = 0;
            return FindItem(RootNode, targetValue);
        }
    }
}
