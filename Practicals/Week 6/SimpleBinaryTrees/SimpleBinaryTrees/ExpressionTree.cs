using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBinaryTrees
{
    public class ExpressionTree : StringBinaryTree
    {
        public ExpressionTree()
        {
            RootNode = null;
        }

        public ExpressionTree(String rootValue)
        {
            RootNode = new StringBinaryTreeNode(rootValue);
        }

        public ExpressionTree(String rootValue, StringBinaryTree leftSubtree, StringBinaryTree rightSubtree)
        {
            RootNode = new StringBinaryTreeNode(rootValue);
            StringBinaryTreeNode leftRoot = leftSubtree.RootNode;
            StringBinaryTreeNode rightRoot = rightSubtree.RootNode;
            RootNode.LeftChild = leftRoot;
            RootNode.RightChild = rightRoot;
        }

        //Parses a given expression tree calculating the value
        public int ParseExpressionTree(StringBinaryTreeNode inputRootNode)
        {
            if (inputRootNode.LeftChild != null && inputRootNode.RightChild != null)
            {
                StringBinaryTreeNode leftRoot = inputRootNode.LeftChild;
                StringBinaryTreeNode rightRoot = inputRootNode.RightChild;
                return Calculate(ParseExpressionTree(leftRoot), ParseExpressionTree(rightRoot), inputRootNode.NodeData);
            }
            else
                return Convert.ToInt16(inputRootNode.NodeData);
        }

        //Appends textBox with each node value using postorder traversal
        public void GeneratePostfixNotation(StringBinaryTreeNode inputRootNode, TextBox textBox)
        {
            if (inputRootNode != null)
            {
                StringBinaryTreeNode leftRoot = inputRootNode.LeftChild;
                GeneratePostfixNotation(leftRoot, textBox);

                StringBinaryTreeNode rightRoot = inputRootNode.RightChild;
                GeneratePostfixNotation(rightRoot, textBox);

                String currentNodeValue = inputRootNode.NodeData;
                textBox.AppendText(currentNodeValue);
            }
        }

        //Calculate two values based on operand given
        public int Calculate(int x, int y, String operand)
        {
            int result = 0;
            switch(operand)
            {
                case "+":
                    result = x + y;
                    break;
                case "-":
                    result = x - y;
                    break;
                case "*":
                    result = x * y;
                    break;
                case "/":
                    result = x / y;
                    break;
            }
            return result;
        }
    }
}
