using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nQueensPractical
{
    public class nQueensTree
    {
        public ChessBoard rootNode;
        int queenAmount;

        public nQueensTree(int queenAmount)
        {
            this.queenAmount = queenAmount;
            rootNode = new ChessBoard(queenAmount);
        }

        public void TreeGenerator(ref ChessBoard rootNode, int currentColumn)
        {
            if (currentColumn < queenAmount) //Base case if the end of the row is reached
            {
                for (int i = 0; i < queenAmount; i++) //Foreach row column new chessboard node is added and current row data is copied over
                {
                    rootNode.AddChildNode(new ChessBoard(queenAmount));
                    rootNode.childNodes[i].copyChessBoard(rootNode);
                    rootNode.childNodes[i].AddQueen(currentColumn, i); //Queen is added to the current row column
                    TreeGenerator(ref rootNode.childNodes[i], currentColumn + 1); //Recursive call to the next column over in the child node
                }
            }
        }

        //Same as above but checks for legality of board before adding children or recursing
        public void PrunedTreeGenerator(ref ChessBoard rootNode, int currentColumn)
        {
            if (currentColumn != queenAmount && rootNode.IsLegal())
            {
                
                    int rowIndex = 0;
                    for (int i = 0; i < queenAmount; i++)
                    {
                        rootNode.AddChildNode(new ChessBoard(queenAmount));
                        rootNode.childNodes[i].copyChessBoard(rootNode);
                        rootNode.childNodes[i].AddQueen(currentColumn, rowIndex);
                        PrunedTreeGenerator(ref rootNode.childNodes[i], currentColumn + 1);
                        rowIndex++;
                    }              
            }
        }

        //Prints an instance of the board to a listbox
        public void PrintTree(ChessBoard rootNode, ListBox printBox)
        {
            if (rootNode != null)
            {
                if (!rootNode.IsEmpty())
                {
                    printBox.Items.Add("_________________________________________________");
                    rootNode.drawBoard(printBox);
                    printBox.Items.Add("_________________________________________________");
                }
                for (int c = 0; c < queenAmount; c++)
                    PrintTree(rootNode.childNodes[c], printBox);
            }
        }

        //prints only a legal solution to a listbox
        public void PrintSolutions(ChessBoard rootNode, ListBox printBox)
        {
            if (rootNode != null)
            {
                if ((rootNode.IsLeaf()) && (rootNode.IsLegal()))
                {
                    printBox.Items.Add("_________________________________________________");
                    rootNode.drawBoard(printBox);
                    printBox.Items.Add("_________________________________________________");
                }

                for (int c = 0; c < queenAmount; c++)
                {
                    PrintSolutions(rootNode.childNodes[c], printBox);
                }
            }
        }
    }
}
