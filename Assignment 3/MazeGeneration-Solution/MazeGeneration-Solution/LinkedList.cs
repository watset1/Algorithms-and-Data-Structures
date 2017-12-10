using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGeneration_Solution
{
    //Linked list collection that holds Cell Nodes and their values 
    public class LinkedList
    {
        public CellNode head;
        public CellNode tail;

        public LinkedList()
        {
            head = null;
            tail = null;
        }

        public void AddCell(CellNode newCell)
        {
            if (head == null)
            {
                head = newCell;
                tail = newCell;
            }
            else
            {
                tail.Next = newCell;
                tail = newCell;
            }
        }

        public int ListCount()
        {
            int count = 0;
            CellNode nodeWalker = head;

            while (nodeWalker != null)
            {
                count++;
                nodeWalker = nodeWalker.Next;
            }

            return count;
        }

        public void DeleteCell(CellNode cellToDelete)
        {
            CellNode nodeWalker = head;

            //If deleting the only pellet in the list
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                //If deleting first pellet in list when there are more than one in list
                if (cellToDelete == head && cellToDelete.Next != null)
                {
                    head = cellToDelete.Next;
                }

                else
                {
                    while (nodeWalker.Next != cellToDelete)
                    {
                        nodeWalker = nodeWalker.Next;
                    }

                    nodeWalker.Next = cellToDelete.Next;
                    //If deleting last pellet in list
                    if (cellToDelete.Next == null)
                    {
                        tail = nodeWalker;
                    }
                }
            }
        }
    }
}
