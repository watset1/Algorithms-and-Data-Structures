using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nQueensPractical
{
    public class ChessBoard
    {
        public Queen[] row { get; set; }
        public ChessBoard[] childNodes;
        public int childNodeCount;

        public ChessBoard(int queenAmount)//Number of queens passed in
        {
            row = new Queen[queenAmount];

            childNodes = new ChessBoard[queenAmount];
            childNodeCount = 0;
            for (int i = 0; i < childNodes.Length; i++) //Nulling the node and row values
            {
                childNodes[i] = null;
                row[i] = null;
            }
        }

        public void AddQueen(int colIndex, int rowIndex)
        {
            row[rowIndex] = new Queen(colIndex); // New queen is created with their column index number
        }

        public void AddChildNode(ChessBoard child)
        {
            childNodes[childNodeCount] = child;
            childNodeCount++;
        }

        //Copies one board's array to current board
        public void copyChessBoard(ChessBoard boardToCopy)
        {
            for (int i = 0; i < row.Length; i++)
                row[i] = boardToCopy.row[i];
        }

        //Draw current board to listbox
        public void drawBoard(ListBox drawBox)
        {           
            for (int rowCol = 0; rowCol < row.Length; rowCol++)
            {
                String boardString = "";
                for (int rowIndex = 0; rowIndex < row.Length; rowIndex++)
                {
                    if (row[rowIndex] != null)
                        if (row[rowIndex].ColumnIndex == rowCol)
                            boardString += "Q ";
                        else
                            boardString += "* ";
                    else
                        boardString += "* ";
                }
                drawBox.Items.Add(boardString);
            }            
        }

        //Checks the board for illegal positioning
        public bool IsLegal()
        {
            for (int col = 0; col < row.Length; col++)
            {
                if (row[col] != null) //checks if current array value can be evaluated
                {
                    int modifier = 1;
                    int colValue = row[col].ColumnIndex;
                    //After checking if array value to compare against is able to be evaluated and not null, checks the values to the right of the current value
                    for (int rowIndex = col + 1; rowIndex < row.Length; rowIndex++)
                    {
                        if(row[rowIndex] != null)  
                            if (row[rowIndex].ColumnIndex == colValue - modifier || row[rowIndex].ColumnIndex == colValue + modifier || row[rowIndex].ColumnIndex == colValue)
                                return false;
                        modifier++;
                    }
                }
            }
            return true;
        }


        //Checks if chessboard is a decendant of the root node
        public bool IsLeaf()
        {
            for (int i = 0; i < row.Length; i++)
                if (row[i] == null)
                    return false;

            return true;
        }

        //Checks if the array is full of null values indicating it is the original node
        public bool IsEmpty()
        {
            for (int i = 0; i < row.Length; i++)
                if (row[i] != null)
                    return false;

            return true;
        }
    }
}
