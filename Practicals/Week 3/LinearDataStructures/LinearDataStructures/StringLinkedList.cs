using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearDataStructures
{
    public class StringLinkedList
    {
        public StringNode head;
        public StringNode tail;

        public StringLinkedList()
        {
            head = null;
            tail = null;
        }

        public void AddString(String stringToAdd)
        {
            StringNode newString = new StringNode();
            newString.Value = stringToAdd;
            if (head == null)
            {
                head = newString;
                tail = newString;
            }
            else
            {
                tail.Next = newString;
                tail = newString;
            }
        }

        public int ListCount()
        {
            int count = 0;
            StringNode nodeWalker = head;

            while (nodeWalker != null)
            {
                count++;
                nodeWalker = nodeWalker.Next;
            }

            return count;
        }

        public void DeleteString(StringNode StringToDelete)
        {
            StringNode nodeWalker = head;

            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                if (StringToDelete == head && StringToDelete.Next != null)
                {
                    head = StringToDelete.Next;
                }

                else
                {
                    while (nodeWalker.Next != StringToDelete)
                    {
                        nodeWalker = nodeWalker.Next;
                    }

                    nodeWalker.Next = StringToDelete.Next;
                    if (StringToDelete.Next == null)
                    {
                        tail = nodeWalker;
                    }
                }
            }
        }
    }
}
