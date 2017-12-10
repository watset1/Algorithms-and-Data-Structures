using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGeneration_Solution
{
    //FIFO stack class that holds Cell Nodes and their values
    public class CellStack
    {
        LinkedList stackList;       

        public CellStack()
        {
            stackList = new LinkedList();
        }

        public void Push(Cell cell)
        {

            stackList.AddCell(new CellNode(cell));
        }

        public Cell Pop()
        {
            Cell poppedCell;
            try
            {
                poppedCell = stackList.tail.Value;
                stackList.DeleteCell(stackList.tail);           
            }
            catch(NullReferenceException)
            {
                throw new Exception("Attempted to pop from an empty stack");
            }
            return poppedCell;
            
        }

        public Cell Peek()
        {
            
            Cell peekString;
            try
            {
                peekString = stackList.tail.Value;
            }
            catch(NullReferenceException)
            {
                throw new Exception ("Attempted to peek at an empty stack");
            }
            return peekString;
        }

        public int Count()
        {
           return stackList.ListCount();
        }

        public bool IsEmpty()
        {
            if (stackList.ListCount() == 0)
                return true;
            else
                return false;
        }
    }
}
