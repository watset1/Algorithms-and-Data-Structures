using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuffmanCoding
{
    public class BinaryTree
    {
        public HuffmanNode RootNode { get; set; }

        public BinaryTree()
        {
            RootNode = null;
        }

        public BinaryTree(String symbol, int frequency)
        {
            RootNode = new HuffmanNode(symbol, frequency);
        }

        public BinaryTree(String symbol, int frequency, BinaryTree leftSubtree, BinaryTree rightSubtree)
        {
            RootNode = new HuffmanNode(symbol, frequency);
            HuffmanNode leftRoot = leftSubtree.RootNode;
            HuffmanNode rightRoot = rightSubtree.RootNode;
            RootNode.leftChild = leftRoot;
            RootNode.rightChild = rightRoot;
        }

        public void AddLeftSubtree(BinaryTree newLeftSubtree)
        {
            HuffmanNode leftRootNode = newLeftSubtree.RootNode;
            RootNode.leftChild = leftRootNode;
        }

        public void AddRightSubtree(BinaryTree newRightSubtree)
        {
            HuffmanNode rightRootNode = newRightSubtree.RootNode;
            RootNode.rightChild = rightRootNode;
        }

        public void MakeLeftChildNode(String symbol, int frequency)
        {
            HuffmanNode newLeftChildNode = new HuffmanNode(symbol, frequency);
            RootNode.leftChild = newLeftChildNode;
        }

        public void MakeRightChildNode(String symbol, int frequency)
        {
            HuffmanNode newRightChildNode = new HuffmanNode(symbol, frequency);
            RootNode.rightChild = newRightChildNode;
        }

        //Draw huffman tree to show visualisation of tree structure
        public void DrawTree(Graphics canvas, Point treePosition, Size nodeSize)
        {
            PreorderTraversal(RootNode, canvas, new Rectangle(treePosition, nodeSize));
        }

        //Recursive Method to draw tree representation to the canvas
        public void PreorderTraversal(HuffmanNode inputRootNode, Graphics canvas, Rectangle rectangle)
        {
            if (inputRootNode != null)
            {
                //Setting the string to go in node rectangle
                String currentNodeSymbol = inputRootNode.Symbol;
                int currentNodeFrequency = inputRootNode.Frequency;
                String nodeString = currentNodeSymbol + ", " + currentNodeFrequency.ToString();
                //Setting the string position in the node rectangle
                PointF stringPosition = new PointF(rectangle.X + 2, rectangle.Y + (rectangle.Height / 3));
                //Setting font style for the string
                Font font = new Font("Bookman Old Style", rectangle.Height / 3, FontStyle.Bold, GraphicsUnit.Point);
                //Sets the string colour
                Brush brush = new SolidBrush(Color.Black);
                //Sets the rectangle outline colour
                Pen pen = Pens.Black;
                //Setting position for the children's lines
                Point lineStart = new Point(rectangle.X + (rectangle.Width / 2), rectangle.Y + rectangle.Height);
                //Sets end y position of children's lines
                int heightIncrement = rectangle.Width;
                //Draws rectangle and string to canvas
                canvas.DrawRectangle(pen, rectangle);
                canvas.DrawString(nodeString, font, brush, stringPosition);
                //Draws childrens lines
                if (inputRootNode.leftChild != null)
                {
                    Point lineEnd = new Point(rectangle.X - (rectangle.Width / 2), rectangle.Y + heightIncrement);
                    canvas.DrawLine(pen, lineStart, lineEnd);
                }
                if (inputRootNode.rightChild != null)
                {
                    Point lineEnd = new Point(rectangle.X + (rectangle.Width + rectangle.Width / 2), rectangle.Y + heightIncrement);
                    canvas.DrawLine(pen, lineStart, lineEnd);
                }

                //Recursive traversals
                HuffmanNode leftRoot = inputRootNode.leftChild;
                Point leftChildPosition = new Point(rectangle.X - rectangle.Width, rectangle.Y + heightIncrement);
                PreorderTraversal(leftRoot, canvas, new Rectangle(leftChildPosition, rectangle.Size));

                HuffmanNode rightRoot = inputRootNode.rightChild;
                Point rightChildPosition = new Point(rectangle.X + rectangle.Width, rectangle.Y + heightIncrement);
                PreorderTraversal(rightRoot, canvas, new Rectangle(rightChildPosition, rectangle.Size));
            }
        }

        public void PreorderTraversal(HuffmanNode inputRootNode, ListBox targetListBox)
        {
            if (inputRootNode != null)
            {
                String currentNodeSymbol = inputRootNode.Symbol;
                int currentNodeFrequency = inputRootNode.Frequency;
                targetListBox.Items.Add(currentNodeSymbol.ToString() + ", "  + currentNodeFrequency.ToString());

                HuffmanNode leftRoot = inputRootNode.leftChild;
                PreorderTraversal(leftRoot, targetListBox);

                HuffmanNode rightRoot = inputRootNode.rightChild;
                PreorderTraversal(rightRoot, targetListBox);
            }
        }
               
        public void InorderTraversal(HuffmanNode inputRootNode, ListBox targetListBox)
        {
            if (inputRootNode != null)
            {
                HuffmanNode leftRoot = inputRootNode.leftChild;
                InorderTraversal(leftRoot, targetListBox);

                String currentNodeSymbol = inputRootNode.Symbol;
                int currentNodeFrequency = inputRootNode.Frequency;
                targetListBox.Items.Add(currentNodeSymbol.ToString() + " ");

                HuffmanNode rightRoot = inputRootNode.rightChild;
                InorderTraversal(rightRoot, targetListBox);
            }
        }

        public void PostorderTraversal(HuffmanNode inputRootNode, ListBox targetListBox)
        {
            if(inputRootNode != null)
            {
                HuffmanNode leftRoot = inputRootNode.leftChild;
                PostorderTraversal(leftRoot, targetListBox);

                HuffmanNode rightRoot = inputRootNode.rightChild;
                PostorderTraversal(rightRoot, targetListBox);

                String currentNodeSymbol = inputRootNode.Symbol;
                int currentNodeFrequency = inputRootNode.Frequency;
                targetListBox.Items.Add(currentNodeSymbol.ToString() + " ");
            }
        }         
    }
}
