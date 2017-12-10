using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    public class IntLinkedList
    {
        public IntNode head;
        public IntNode tail;

        public IntLinkedList()
        {
            head = null;
            tail = null;
        }

        public void AddInt(int intToAdd)
        {
            IntNode newInt = new IntNode();
            newInt.Value = intToAdd;
            if (head == null)
            {
                head = newInt;
                tail = newInt;
            }
            else
            {
                tail.Next = newInt;
                tail = newInt;
            }
        }

        public int ListCount()
        {
            int count = 0;
            IntNode nodeWalker = head;

            while (nodeWalker != null)
            {
                count++;
                nodeWalker = nodeWalker.Next;
            }

            return count;
        }

        public void DeleteInt(IntNode IntToDelete)
        {
            IntNode nodeWalker = head;

            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                if (IntToDelete == head && IntToDelete.Next != null)
                {
                    head = IntToDelete.Next;
                }

                else
                {
                    while (nodeWalker.Next != IntToDelete)
                    {
                        nodeWalker = nodeWalker.Next;
                    }

                    nodeWalker.Next = IntToDelete.Next;
                    if (IntToDelete.Next == null)
                    {
                        tail = nodeWalker;
                    }
                }
            }
        }
    }
}
